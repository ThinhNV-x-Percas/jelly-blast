using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Examples
{
    public class CylinderMeshCreator : PathSceneTool
    {
        [Tooltip("Radius of the cylinder and hemisphere caps.")]
        public float thickness;

        [Range(3f, 30f)]
        public int resolutionU;

        [Min(0f)]
        public float resolutionV;

        [Tooltip("Enable to add hemispherical caps at the ends of the cylinder.")]
        public bool addCaps;

        [Tooltip("Number of segments from pole to equator for each hemispherical cap.")]
        [Min(1f)]
        public int capSegmentsV;

        public Material material;

        private MeshFilter meshFilter;
        private MeshRenderer meshRenderer;
        private Mesh mesh;

        // PathSceneTool is only driven by its editor inspector, and the prefab ships with
        // m_Mesh: {fileID: 0} - nothing rebuilt the tube at runtime, so it was invisible.
        // Same hook PathCollider2D already uses for the collider half.
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

            AssignMeshComponents();
            AssignMaterials();
            CreateMesh();
        }

        private void CreateMesh()
        {
            var verts = new List<Vector3>();
            var normals = new List<Vector3>();
            var triangles = new List<int>();

            if (path == null)
                return;

            // Decompiled native code matches the original Path-Creator sampling rule:
            // round(path length * resolutionV) + 1, with at least 2 rings.
            int numCircles = Mathf.Max(2, Mathf.RoundToInt(path.length * resolutionV) + 1);
            int radialSegments = Mathf.Max(1, resolutionU);

            if (radialSegments < 1)
            {
                ClearMesh();
                return;
            }

            var pathInstruction = EndOfPathInstruction.Stop;

            for (int s = 0; s < numCircles; s++)
            {
                float segmentPercent = s / (numCircles - 1f);

                Vector3 centerPos = path.GetPointAtTime(segmentPercent, pathInstruction);
                Vector3 pathNormal = path.GetNormal(segmentPercent, pathInstruction);
                Vector3 forward = path.GetDirection(segmentPercent, pathInstruction);
                Vector3 tangent = Vector3.Cross(pathNormal, forward);

                int ringStart = s * radialSegments;

                for (int currentRes = 0; currentRes < radialSegments; currentRes++)
                {
                    float angle = (currentRes / (float)radialSegments) * (Mathf.PI * 2f);
                    float sin = Mathf.Sin(angle);
                    float cos = Mathf.Cos(angle);

                    Vector3 radial = pathNormal * sin + tangent * cos;
                    Vector3 point = centerPos + radial * thickness;

                    verts.Add(transform.InverseTransformPoint(point));
                    normals.Add(ToLocalNormal(radial));

                    if (s >= numCircles - 1)
                        continue;

                    int nextRing = ringStart + radialSegments;
                    int nextRes = (currentRes + 1) % radialSegments;

                    // Preserve the winding used by the original Path-Creator implementation.
                    triangles.Add(ringStart + currentRes);
                    triangles.Add(ringStart + nextRes);
                    triangles.Add(nextRing + currentRes);

                    triangles.Add(ringStart + nextRes);
                    triangles.Add(nextRing + nextRes);
                    triangles.Add(nextRing + currentRes);
                }
            }

            if (addCaps && capSegmentsV >= 1 && radialSegments >= 1)
            {
                // The side mesh already contains the cylinder end rings.
                // The hemisphere poles/rings are appended after the side mesh.
                int startOffset = verts.Count;
                AddHemisphereCap(0f, true, ref verts, ref normals, ref triangles, startOffset);
                int endOffset = verts.Count;
                AddHemisphereCap(1f, false, ref verts, ref normals, ref triangles, endOffset);
            }

            if (mesh == null)
                mesh = new Mesh();
            else
                mesh.Clear();

            mesh.SetVertices(verts);
            mesh.SetNormals(normals);
            mesh.SetTriangles(triangles, 0);
            mesh.RecalculateBounds();

            if (meshFilter != null)
                meshFilter.sharedMesh = mesh;
        }

        private void AddHemisphereCap(
            float t,
            bool startCap,
            ref List<Vector3> verts,
            ref List<Vector3> normals,
            ref List<int> triangles,
            int vertOffset)
        {
            if (path == null || capSegmentsV < 1 || resolutionU < 1)
                return;

            Vector3 center = path.GetPointAtTime(t, EndOfPathInstruction.Stop);
            Vector3 pathNormal = path.GetNormal(t, EndOfPathInstruction.Stop);
            Vector3 forward = path.GetDirection(t, EndOfPathInstruction.Stop);

            // The decompiled implementation uses +/- path direction as the cap pole
            // and reuses the path normal/cross-normal as the circular basis.
            Vector3 poleDirection = startCap ? -forward : forward;
            Vector3 tangent = Vector3.Cross(pathNormal, forward);

            int segmentsU = Mathf.Max(1, resolutionU);
            int segmentCount = Mathf.Max(1, capSegmentsV);

            // Pole.
            int poleIndex = vertOffset;
            Vector3 polePosition = center + poleDirection * thickness;
            verts.Add(transform.InverseTransformPoint(polePosition));
            normals.Add(ToLocalNormal(poleDirection));

            // Pole -> equator rings.
            for (int ring = 1; ring <= segmentCount; ring++)
            {
                float theta = (ring / (float)segmentCount) * (Mathf.PI * 0.5f);
                float sinTheta = Mathf.Sin(theta);
                float cosTheta = Mathf.Cos(theta);

                int currentRingStart = verts.Count;

                // The whole ring has to exist before any triangle is emitted: AddTriangle
                // READS verts[]/normals[] to correct winding, and the original interleaved
                // loop indexed the next vertex of the ring before adding it - which threw
                // ArgumentOutOfRangeException out of PathUpdated and left the tube empty.
                for (int currentRes = 0; currentRes < segmentsU; currentRes++)
                {
                    float phi = (currentRes / (float)segmentsU) * (Mathf.PI * 2f);
                    Vector3 radial = pathNormal * Mathf.Sin(phi) + tangent * Mathf.Cos(phi);
                    Vector3 sphereNormal = poleDirection * cosTheta + radial * sinTheta;

                    verts.Add(transform.InverseTransformPoint(center + sphereNormal * thickness));
                    normals.Add(ToLocalNormal(sphereNormal));
                }

                for (int currentRes = 0; currentRes < segmentsU; currentRes++)
                {
                    int nextRes = (currentRes + 1) % segmentsU;

                    if (ring == 1)
                    {
                        if (startCap)
                        {
                            AddTriangle(triangles, poleIndex, currentRingStart + nextRes, currentRingStart + currentRes, verts, normals);
                        }
                        else
                        {
                            AddTriangle(triangles, poleIndex, currentRingStart + currentRes, currentRingStart + nextRes, verts, normals);
                        }

                        continue;
                    }

                    int previousRingStart = currentRingStart - segmentsU;
                    int a = previousRingStart + currentRes;
                    int b = previousRingStart + nextRes;
                    int c = currentRingStart + currentRes;
                    int d = currentRingStart + nextRes;

                    if (startCap)
                    {
                        AddTriangle(triangles, d, b, a, verts, normals);
                        AddTriangle(triangles, d, c, b, verts, normals);
                    }
                    else
                    {
                        AddTriangle(triangles, a, b, d, verts, normals);
                        AddTriangle(triangles, a, d, c, verts, normals);
                    }
                }
            }
        }

        private void AddTriangle(
            List<int> triangles,
            int a,
            int b,
            int c,
            List<Vector3> verts,
            List<Vector3> normals)
        {
            // The native code's winding is cap-direction dependent.
            // Correct the winding if numerical/path-space orientation flips.
            Vector3 va = verts[a];
            Vector3 vb = verts[b];
            Vector3 vc = verts[c];

            Vector3 triangleNormal = Vector3.Cross(vb - va, vc - va);
            Vector3 expectedNormal = normals[a] + normals[b] + normals[c];

            if (triangleNormal.sqrMagnitude > 1e-12f &&
                expectedNormal.sqrMagnitude > 1e-12f &&
                Vector3.Dot(triangleNormal, expectedNormal) < 0f)
            {
                int tmp = b;
                b = c;
                c = tmp;
            }

            triangles.Add(a);
            triangles.Add(b);
            triangles.Add(c);
        }

        private Vector3 ToLocalNormal(Vector3 worldNormal)
        {
            float magnitude = worldNormal.magnitude;
            if (magnitude <= 1e-5f)
                return Vector3.zero;

            return transform.InverseTransformDirection(worldNormal / magnitude).normalized;
        }

        private void ClearMesh()
        {
            if (mesh == null)
                mesh = new Mesh();
            else
                mesh.Clear();

            if (meshFilter != null)
                meshFilter.sharedMesh = mesh;
        }

        private void AssignMeshComponents()
        {
            meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null)
                meshFilter = gameObject.AddComponent<MeshFilter>();

            meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer == null)
                meshRenderer = gameObject.AddComponent<MeshRenderer>();

            if (mesh == null)
                mesh = new Mesh();

            meshFilter.sharedMesh = mesh;
        }

        private void AssignMaterials()
        {
            if (meshRenderer != null && material != null)
                meshRenderer.sharedMaterial = material;
        }

        public CylinderMeshCreator()
        {
            thickness = 0.15f;
            resolutionV = 20f;
            capSegmentsV = 10;
        }
    }
}
