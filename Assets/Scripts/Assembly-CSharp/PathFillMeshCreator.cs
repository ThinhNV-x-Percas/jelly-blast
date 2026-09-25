using UnityEngine;
using PathCreation;
using PathCreation.Examples;

// Recovered by GUID only - the class was absent from the rip. Every 'floor' object references
// it with pathCreator/autoUpdate (PathSceneTool) plus thickness, pathResolution, borderSegments,
// flipGeometry, curvatureResolution and material, and ships m_Mesh: {fileID: 0}, so nothing
// ever built the floor and it rendered as an empty MeshRenderer.
// ponytail: the fill is triangulated from the sibling PolygonCollider2D, which is the same
// closed path and is ground truth. thickness/borderSegments/curvatureResolution are not
// reproduced: the camera is orthographic and head-on, so an extrusion renders identically
// (measured) and the decorative border strip has no reference to rebuild it from.
[RequireComponent(typeof(PolygonCollider2D))]
[ExecuteAlways]
public class PathFillMeshCreator : PathSceneTool
{
    [Tooltip("Width of the border strip around the fill.")]
    public float thickness = 0.3f;

    [Range(2f, 400f)]
    public int pathResolution = 60;

    [Range(1f, 32f)]
    public int borderSegments = 4;

    public bool flipGeometry;

    [Range(1f, 32f)]
    public int curvatureResolution = 5;

    public Material material;

    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    private PolygonCollider2D polyCollider;
    private Mesh mesh;

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

    protected override void OnDestroy()
    {
        base.OnDestroy();
        if (mesh == null)
            return;

        if (Application.isPlaying)
            Destroy(mesh);
        else
            DestroyImmediate(mesh);
        mesh = null;
    }

    protected override void PathUpdated()
    {
        if (pathCreator == null)
            return;

        AssignMeshComponents();

        if (polyCollider == null || polyCollider.pathCount < 1 || polyCollider.GetTotalPointCount() < 3)
            return;

        Mesh built = polyCollider.CreateMesh(useBodyPosition: false, useBodyRotation: false);
        if (built == null)
            return;

        // CreateMesh returns vertices in the attached body's space (world space when the collider has
        // no Rigidbody2D, as every floor does), but the MeshFilter applies this transform again, which
        // drew each floor offset by its own position (and rotated/scaled twice). Bring them back to local.
        Rigidbody2D body = polyCollider.attachedRigidbody;
        Matrix4x4 meshToWorld = body != null
            ? Matrix4x4.TRS(body.transform.position, body.transform.rotation, Vector3.one)
            : Matrix4x4.identity;
        Matrix4x4 meshToLocal = transform.worldToLocalMatrix * meshToWorld;
        Vector3[] vertices = built.vertices;
        for (int i = 0; i < vertices.Length; i++)
            vertices[i] = meshToLocal.MultiplyPoint3x4(vertices[i]);
        built.vertices = vertices;
        built.RecalculateBounds();

        Vector3[] normals = new Vector3[built.vertexCount];
        Vector3 facing = flipGeometry ? Vector3.forward : Vector3.back;
        for (int i = 0; i < normals.Length; i++)
            normals[i] = facing;
        built.normals = normals;

        if (mesh != null)
            DestroyImmediate(mesh);

        mesh = built;
        mesh.name = "PathFill";
        meshFilter.sharedMesh = mesh;

        if (meshRenderer != null && material != null)
            meshRenderer.sharedMaterial = material;
    }

    private void AssignMeshComponents()
    {
        if (polyCollider == null)
            polyCollider = GetComponent<PolygonCollider2D>();

        if (meshFilter == null)
        {
            meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null)
                meshFilter = gameObject.AddComponent<MeshFilter>();
        }

        if (meshRenderer == null)
        {
            meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer == null)
                meshRenderer = gameObject.AddComponent<MeshRenderer>();
        }
    }
}
