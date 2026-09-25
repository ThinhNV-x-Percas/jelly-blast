using System.Collections.Generic;
using PathCreation;
using UnityEngine;

[RequireComponent(typeof(PathCreator))]
[RequireComponent(typeof(PolygonCollider2D))]
[ExecuteAlways]
public class PathCollider2D : MonoBehaviour
{
    [Tooltip("Total width of the collider.")]
    public float thickness = 0.2f;

    [Range(2f, 200f)]
    [Tooltip("Number of segments along the path (minimum 2).")]
    public int resolution;

    private PathCreator pathCreator;
    private PolygonCollider2D polyCollider;

    private void Awake()
    {
        pathCreator = GetComponent<PathCreator>();
        polyCollider = GetComponent<PolygonCollider2D>();
    }

    private void OnEnable()
    {
        pathCreator.pathUpdated += UpdateCollider;
        UpdateCollider();
    }

    private void OnDisable()
    {
        pathCreator.pathUpdated -= UpdateCollider;
    }

    private void UpdateCollider()
    {
        VertexPath path = pathCreator.path;
        if (path == null || resolution < 2)
        {
            return;
        }

        EndOfPathInstruction endOfPath = path.isClosedLoop ? EndOfPathInstruction.Loop : EndOfPathInstruction.Stop;
        List<Vector2> left = new List<Vector2>(resolution);
        List<Vector2> right = new List<Vector2>(resolution);
        float halfThickness = thickness * 0.5f;
        for (int i = 0; i < resolution; i++)
        {
            float t = (float)i / (resolution - 1);
            Vector3 worldPoint = path.GetPointAtTime(t, endOfPath);
            Vector2 direction = ((Vector2)path.GetDirection(t, endOfPath)).normalized;
            Vector2 localPoint = transform.InverseTransformPoint(worldPoint);
            Vector2 offset = new Vector2(-direction.y, direction.x) * halfThickness;
            left.Add(localPoint + offset);
            right.Add(localPoint - offset);
        }

        List<Vector2> outline = new List<Vector2>(resolution * 2);
        outline.AddRange(left);
        right.Reverse();
        outline.AddRange(right);
        polyCollider.pathCount = 1;
        polyCollider.SetPath(0, outline);
    }
}
