using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    [Header("Endpoints (drag to move)")]
    public Rigidbody2D startPoint;
    public Rigidbody2D endPoint;

    [Tooltip("World-space sag beneath the mid-point.")]
    [Min(0f)]
    public float sagDepth = 0.25f;

    [Header("Link Geometry")]
    [Tooltip("Half-length of a prefab (centre → joint attach).")]
    public float anchorOffset = 0.15f;

    [Tooltip("Rigidbody2D prefab for a single link.")]
    public Rigidbody2D linkPrefab;

    private readonly List<Rigidbody2D> _links = new List<Rigidbody2D>();

    private Vector2 _lastStartPos;
    private Vector2 _lastEndPos;

    private const float MoveThresholdSqr = 1e-10f;

    private void Awake()
    {
        if (Application.isPlaying)
        {
            RebuildRuntime();
        }
    }

    private void Update()
    {
        if (!Application.isPlaying)
        {
            return;
        }

        bool startMoved = (startPoint.position - _lastStartPos).sqrMagnitude >= MoveThresholdSqr;
        bool endMoved = (endPoint.position - _lastEndPos).sqrMagnitude >= MoveThresholdSqr;
        if (startMoved || endMoved)
        {
            RebuildRuntime();
        }
    }

    private void RebuildRuntime()
    {
        for (int i = _links.Count - 1; i >= 0; i--)
        {
            Destroy(_links[i].gameObject);
        }

        _links.Clear();

        Vector2 start = startPoint.position;
        Vector2 end = endPoint.position;
        Vector2 mid = (start + end) * 0.5f + Vector2.down * sagDepth;

        float bezLen = ApproxQuadLen(start, mid, end);
        int linkCount = Mathf.Clamp(Mathf.RoundToInt(bezLen / (anchorOffset * 2f)) + 1, 2, 64);
        float[] ts = EvenTByArc(start, mid, end, linkCount, bezLen);
        SpawnLinks(start, mid, end, ts, startPoint, endPoint);

        _lastStartPos = start;
        _lastEndPos = end;
    }

    private void SpawnLinks(Vector2 p0, Vector2 p1, Vector2 p2, float[] ts, Rigidbody2D rbStart, Rigidbody2D rbEnd)
    {
        Rigidbody2D previous = rbStart;
        for (int i = 0; i < ts.Length; i++)
        {
            float t = ts[i];
            Vector2 point = Bezier(p0, p1, p2, t);
            Vector2 tangent = BezierDeriv(p0, p1, p2, t);
            Vector2 direction = tangent.magnitude > 1e-5f ? tangent.normalized : Vector2.zero;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;

            Rigidbody2D link = CreateLink(new Vector3(point.x, point.y, 0f), Quaternion.Euler(0f, 0f, angle), i);
            Vector2 previousAnchor = i == 0 ? Vector2.zero : new Vector2(0f, anchorOffset * -0.5f);
            ConnectRope(link, previous, new Vector2(0f, anchorOffset), previousAnchor);
            _links.Add(link);
            previous = link;
        }

        Rigidbody2D last = _links[_links.Count - 1];
        ConnectRope(last, rbEnd, new Vector2(0f, anchorOffset * -0.5f), Vector2.zero);
    }

    private void ConnectRope(Rigidbody2D rb, Rigidbody2D target, Vector2 localAnchor, Vector2 targetAnchor)
    {
        DistanceJoint2D joint = rb.gameObject.AddComponent<DistanceJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.anchor = localAnchor;
        joint.connectedBody = target;
        joint.connectedAnchor = targetAnchor;
        joint.autoConfigureDistance = true;
        joint.maxDistanceOnly = true;
        joint.enableCollision = false;
    }

    private static Vector2 Bezier(Vector2 a, Vector2 b, Vector2 c, float t)
    {
        float u = 1f - t;
        return a * (u * u) + b * (2f * u * t) + c * (t * t);
    }

    private static Vector2 BezierDeriv(Vector2 a, Vector2 b, Vector2 c, float t)
    {
        return ((b - a) * (1f - t) + (c - b) * t) * 2f;
    }

    private static float ApproxQuadLen(Vector2 a, Vector2 b, Vector2 c, int n = 16)
    {
        float total = 0f;
        Vector2 prev = a;
        for (int i = 1; i <= n; i++)
        {
            Vector2 point = Bezier(a, b, c, (float)i / n);
            total += Vector2.Distance(prev, point);
            prev = point;
        }

        return total;
    }

    // Returns linkCount curve parameters spaced evenly by arc length (endpoints excluded).
    private static float[] EvenTByArc(Vector2 a, Vector2 b, Vector2 c, int linkCount, float bezLen, int table = 60)
    {
        float dt = 1f / table;
        float[] cumulative = new float[table + 1];
        Vector2 prev = a;
        for (int i = 1; i <= table; i++)
        {
            Vector2 point = Bezier(a, b, c, dt * i);
            cumulative[i] = cumulative[i - 1] + Vector2.Distance(prev, point);
            prev = point;
        }

        float[] result = new float[linkCount];
        float step = bezLen / (linkCount + 1);
        int segment = 0;
        for (int i = 0; i < linkCount; i++)
        {
            float targetLength = step * (i + 1);
            while (segment < table - 1 && cumulative[segment + 1] < targetLength)
            {
                segment++;
            }

            float segmentStart = cumulative[segment];
            float segmentEnd = cumulative[segment + 1];
            float localT = segmentEnd > segmentStart
                ? Mathf.Clamp01((targetLength - segmentStart) / (segmentEnd - segmentStart))
                : 0f;
            float t0 = dt * segment;
            float t1 = dt * (segment + 1);
            result[i] = t0 + (t1 - t0) * localT;
        }

        return result;
    }

    private Rigidbody2D CreateLink(Vector3 pos, Quaternion rot, int i)
    {
        Rigidbody2D link = Instantiate(linkPrefab, pos, rot, transform);
        MeshRenderer linkRenderer = link.GetComponentInChildren<MeshRenderer>();
        // Alternate link meshes by 90 degrees so neighbouring links interlock visually.
        float yaw = (i & 1) == 0 ? 90f : 0f;
        linkRenderer.transform.localRotation = Quaternion.Euler(0f, yaw, 0f);
        return link;
    }
}
