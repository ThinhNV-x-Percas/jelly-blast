using System.Collections.Generic;
using UnityEngine;
using PathCreation;

// Recovered by GUID only: the class itself was absent from the rip, but every level prefab
// that carries a 'floor' references it with one serialized field, `resolution`, and its baked
// PolygonCollider2D holds exactly `resolution` points sampled off the closed path.
[RequireComponent(typeof(PathCreator))]
[RequireComponent(typeof(PolygonCollider2D))]
[ExecuteAlways]
public class PathPolygonCollider2D : MonoBehaviour
{
    [Range(3f, 200f)]
    [Tooltip("Number of points sampled around the closed path.")]
    public int resolution = 50;

    private PathCreator pathCreator;
    private PolygonCollider2D polyCollider;

    private void Awake()
    {
        pathCreator = GetComponent<PathCreator>();
        polyCollider = GetComponent<PolygonCollider2D>();
    }

    private void OnEnable()
    {
        if (pathCreator == null)
            pathCreator = GetComponent<PathCreator>();
        if (polyCollider == null)
            polyCollider = GetComponent<PolygonCollider2D>();

        pathCreator.pathUpdated += UpdateCollider;
        UpdateCollider();
    }

    private void OnDisable()
    {
        if (pathCreator != null)
            pathCreator.pathUpdated -= UpdateCollider;
    }

    public void UpdateCollider()
    {
        VertexPath path = pathCreator != null ? pathCreator.path : null;
        if (path == null || polyCollider == null || resolution < 3)
            return;

        List<Vector2> points = new List<Vector2>(resolution);
        for (int i = 0; i < resolution; i++)
        {
            float t = (float)i / resolution;
            Vector3 world = path.GetPointAtTime(t, EndOfPathInstruction.Loop);
            points.Add(transform.InverseTransformPoint(world));
        }

        polyCollider.pathCount = 1;
        polyCollider.SetPath(0, points);
    }
}
