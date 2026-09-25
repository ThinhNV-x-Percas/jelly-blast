using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Examples
{
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class PlanarLineMeshCreator : PathSceneTool
    {
        [Header("Shape")]
        [Tooltip("Half-width of the ribbon (world units).")]
        public float thickness = 0.05f;

        [Tooltip("Sub-samples per repeat segment (smoothness).")]
        [Range(1f, 20f)]
        public int subdivisionsPerSegment;

        [Header("Layering")]
        [Tooltip("Local-space Z written into every vertex.")]
        public float localZ;

        [Header("UV Options")]
        public bool flipU;
        public bool flipV;

        private MeshFilter mf;
        private MeshRenderer mr;
        private Mesh mesh;

        public float innerSegmentLengthRatio = 4f;

        // PathSceneTool is only driven by its editor inspector and the level prefabs ship with
        // m_Mesh: {fileID: 0}, so without this the ribbon is never built at runtime.
        // Same hook CylinderMeshCreator and PathFillMeshCreator use.
        private void OnEnable()
        {
            if (pathCreator == null)
                return;
            pathCreator.pathUpdated += PathUpdated;
            PathUpdated();
        }

        private void OnDisable()
        {
            if (pathCreator != null)
                pathCreator.pathUpdated -= PathUpdated;
        }

        protected override void PathUpdated()
        {
            if (pathCreator == null)
                return;
            if (mf == null)
                mf = GetComponent<MeshFilter>();
            if (mr == null)
                mr = GetComponent<MeshRenderer>();
            BuildMesh();
        }

        private void BuildMesh()
        {
            if (mesh == null)
                mesh = new Mesh();
            else
                mesh.Clear();

            VertexPath vertexPath = pathCreator.path;
            float pathLength = vertexPath.length;

            // Layout along the path: an end cap of length `thickness` at each end and
            // evenly sized repeat segments of roughly thickness * innerSegmentLengthRatio in between.
            float usableLength = Mathf.Max(0f, pathLength - thickness * 2f);
            int numInnerSegments = 0;
            float innerSegmentLength = 0f;
            if (usableLength > 0f)
            {
                float targetSegmentLength = thickness * innerSegmentLengthRatio;
                numInnerSegments = Mathf.Max(1, Mathf.RoundToInt(usableLength / targetSegmentLength));
                innerSegmentLength = usableLength / numInnerSegments;
            }

            var segmentStarts = new List<float> { 0f };
            var segmentEnds = new List<float> { thickness };
            for (int i = 0; i < numInnerSegments; i++)
            {
                float start = thickness + i * innerSegmentLength;
                segmentStarts.Add(start);
                segmentEnds.Add(start + innerSegmentLength);
            }
            segmentStarts.Add(pathLength - thickness);
            segmentEnds.Add(pathLength);

            int subdivisions = Mathf.Max(1, subdivisionsPerSegment);

            // Each segment gets its own run of samples so its UVs restart at 0 (repeating texture).
            var sampleDistances = new List<float>();
            var sampleSegmentIndex = new List<int>();
            var sampleT = new List<float>();
            for (int i = 0; i < segmentStarts.Count; i++)
            {
                float start = segmentStarts[i];
                float length = segmentEnds[i] - start;
                for (int j = 0; j <= subdivisions; j++)
                {
                    float t = (float)j / subdivisions;
                    sampleDistances.Add(start + length * t);
                    sampleSegmentIndex.Add(i);
                    sampleT.Add(t);
                }
            }

            if (sampleDistances.Count < 2)
            {
                mf.sharedMesh = mesh;
                return;
            }

            int vertexCount = sampleDistances.Count * 2;
            var verts = new List<Vector3>(vertexCount);
            var uvs = new List<Vector2>(vertexCount);
            var normals = new List<Vector3>(vertexCount);
            var triangles = new List<int>(sampleDistances.Count * 6);

            Transform tr = transform;
            Vector3 localNormal = tr.InverseTransformDirection(Vector3.back);
            float normalLength = localNormal.magnitude;
            localNormal = normalLength > 1E-05f ? localNormal / normalLength : Vector3.back;

            float vA = flipV ? 1f : 0f;
            float vB = flipV ? 0f : 1f;

            for (int k = 0; k < sampleDistances.Count; k++)
            {
                float d = sampleDistances[k];
                Vector3 point = vertexPath.GetPointAtDistance(d, EndOfPathInstruction.Stop);
                Vector3 dir = vertexPath.GetDirectionAtDistance(d, EndOfPathInstruction.Stop);

                // Perpendicular in the XY plane.
                float dirLength = Mathf.Sqrt(dir.x * dir.x + dir.y * dir.y);
                float px = 0f;
                float py = 0f;
                if (dirLength > 1E-05f)
                {
                    px = -dir.y / dirLength;
                    py = dir.x / dirLength;
                }

                var leftWorld = new Vector3(point.x - px * thickness, point.y - py * thickness, point.z);
                var rightWorld = new Vector3(point.x + px * thickness, point.y + py * thickness, point.z);
                Vector3 leftLocal = tr.InverseTransformPoint(leftWorld);
                leftLocal.z = localZ;
                Vector3 rightLocal = tr.InverseTransformPoint(rightWorld);
                rightLocal.z = localZ;
                verts.Add(leftLocal);
                verts.Add(rightLocal);
                normals.Add(localNormal);
                normals.Add(localNormal);

                float u = flipU ? 1f - sampleT[k] : sampleT[k];
                uvs.Add(new Vector2(u, vA));
                uvs.Add(new Vector2(u, vB));
            }

            for (int k = 1; k < sampleDistances.Count; k++)
            {
                if (sampleSegmentIndex[k] != sampleSegmentIndex[k - 1])
                    continue;
                int baseIndex = (k - 1) * 2;
                triangles.Add(baseIndex);
                triangles.Add(baseIndex + 1);
                triangles.Add(baseIndex + 2);
                triangles.Add(baseIndex + 2);
                triangles.Add(baseIndex + 1);
                triangles.Add(baseIndex + 3);
            }

            mesh.SetVertices(verts);
            mesh.SetUVs(0, uvs);
            mesh.SetNormals(normals);
            mesh.SetTriangles(triangles, 0);
            mesh.RecalculateBounds();
            mf.sharedMesh = mesh;
        }
    }
}
