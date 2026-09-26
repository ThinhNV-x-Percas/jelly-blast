using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(FluidSolver))]
public class FluidPhysicsCoupler : MonoBehaviour
{
    internal enum Shape : byte
    {
        Circle = 0,
        Box = 1
    }

    private struct BodyInfo
    {
        public Shape shape;
        public Rigidbody2D body;
        public float radiusWS;
        public float2 halfExtentsLS;
        public Vector2 localOffset;
    }

    internal struct BodyData
    {
        public Shape shape;
        public float2 com;
        public float2x2 R;
        public float2 halfExtents;
        public float radius;
        public float invMass;
        public float invInertia;
        public float2 vel;
        public float angVel;
        public float2 offsetWS;
        public bool isKinematic;
        // Radius of the circle enclosing the shape, for a cheap reject before the exact test.
        public float boundRadius;
    }

    internal struct ForceBundle
    {
        public int bodyIndex;
        public float2 force;
        public float torque;
    }

    [BurstCompile(FloatPrecision.Low, FloatMode.Fast, CompileSynchronously = true)]
    internal struct CouplerJob : IJobParallelFor
    {
        [NativeDisableParallelForRestriction]
        public NativeArray<float2> positions;

        [NativeDisableParallelForRestriction]
        public NativeArray<float2> velocities;

        [ReadOnly]
        public NativeArray<BodyData> bodies;

        [NativeDisableParallelForRestriction]
        public NativeArray<ForceBundle> result;

        [ReadOnly]
        public NativeArray<bool> isStatic;

        public float invFluidMass;
        public float restitution;
        public float dt;
        public float particleRadius;
        public float mu;
        public float2 halfBounds;

        [ReadOnly]
        public NativeArray<float4> sdf;

        public int2 sdfRes;
        public float2 invWorldPerTexel;
        public float2 sdfCenter;

        public void Execute(int p)
        {
            float2 pos = positions[p];
            float2 vP = velocities[p];
            bool frozen = isStatic[p];

            for (int i = 0; i < bodies.Length; i++)
            {
                BodyData body = bodies[i];
                float2 delta = pos - (body.com + body.offsetWS);

                float2 normal;
                float2 leverArm;
                float penetration;

                if (body.shape == Shape.Circle)
                {
                    float minDist = body.radius + particleRadius;
                    float distSq = delta.x * delta.x + delta.y * delta.y;
                    if (distSq >= minDist * minDist)
                        continue;

                    float dist = math.sqrt(distSq);
                    normal = dist > 1E-06f ? delta / dist : new float2(0f, 1f);
                    leverArm = normal * body.radius + body.offsetWS;
                    penetration = minDist - dist;
                }
                else if (math.lengthsq(delta) > Square(body.boundRadius + particleRadius)
                         || !BoxContact(in body, delta, particleRadius, out normal, out leverArm, out penetration))
                {
                    continue;
                }

                float2 netForce = float2.zero;
                float netTorque = 0f;
                ResolveBody(frozen, ref vP, normal, leverArm, penetration, in body, ref netForce, ref netTorque);
                AccumulateForce(i, netForce, netTorque);
            }

            if (!frozen)
            {
                float2 limit = halfBounds - particleRadius;
                if (pos.x < -limit.x)
                    ResolveWall(frozen, ref vP, new float2(1f, 0f), -limit.x - pos.x);
                else if (pos.x > limit.x)
                    ResolveWall(frozen, ref vP, new float2(-1f, 0f), pos.x - limit.x);

                SampleSDF(pos, in sdf, sdfRes, halfBounds, invWorldPerTexel, sdfCenter, out float phi, out float2 sdfNormal);
                if (phi < particleRadius)
                    ResolveWall(frozen, ref vP, sdfNormal, particleRadius - phi);

                float minY = LowerBound(limit.y, sdfCenter.y);
                float maxY = UpperBound(limit.y, sdfCenter.y);
                if (pos.y < minY)
                    ResolveWall(frozen, ref vP, new float2(0f, 1f), minY - pos.y);
                else if (pos.y > maxY)
                    ResolveWall(frozen, ref vP, new float2(0f, -1f), pos.y - maxY);
            }

            velocities[p] = vP;
        }

        private void AccumulateForce(int bodyIndex, float2 force, float torque)
        {
            ForceBundle bundle = result[bodyIndex];
            bundle.bodyIndex = bodyIndex;
            bundle.force += force;
            bundle.torque += torque;
            result[bodyIndex] = bundle;
        }

        private void ResolveBody(bool frozen, ref float2 vP, float2 n, float2 leverArm, float penetration, in BodyData bd, ref float2 netForce, ref float netTorque)
        {
            float2 contactVel = new float2(bd.vel.x - leverArm.y * bd.angVel, bd.vel.y + leverArm.x * bd.angVel);
            float2 relVel = vP - contactVel;
            float vn = n.x * relVel.x + n.y * relVel.y;
            float rn = n.y * leverArm.x - n.x * leverArm.y;
            float invMassTotal = bd.invMass + rn * rn * bd.invInertia + (frozen ? 0f : invFluidMass);

            float normalImpulse = 0f;
            if (vn < 0f)
            {
                float j = -(vn * (restitution + 1f)) / invMassTotal;
                float2 deltaV = n * j;
                if (!frozen)
                    vP += invFluidMass * deltaV;

                float2 force = -deltaV / dt;
                netForce += force;
                netTorque += leverArm.x * force.y - leverArm.y * force.x;
                normalImpulse = math.abs(j);
            }

            if (frozen || mu <= 0f)
                return;

            float vt = n.x * relVel.y - n.y * relVel.x;
            if (math.abs(vt) <= 1E-06f)
                return;

            float maxFriction = normalImpulse * mu;
            float frictionJ = math.clamp(-vt / invMassTotal, -maxFriction, maxFriction);
            float2 frictionDeltaV = new float2(-n.y, n.x) * frictionJ;
            vP += invFluidMass * frictionDeltaV;

            float2 frictionForce = -frictionDeltaV / dt;
            netForce += frictionForce;
            netTorque += leverArm.x * frictionForce.y - leverArm.y * frictionForce.x;
        }

        private void ResolveWall(bool frozen, ref float2 vP, float2 n, float penetration)
        {
            if (frozen)
                return;

            float vn = n.x * vP.x + n.y * vP.y;
            if (vn < 0f)
                vP += n * (-(restitution + 1f) * vn);

            if (mu > 0f)
            {
                float cross = n.x * vP.y - n.y * vP.x;
                vP.x += mu * cross * n.y;
                vP.y -= mu * cross * n.x;
            }
        }
    }

    [BurstCompile(FloatPrecision.Low, FloatMode.Fast, CompileSynchronously = true)]
    internal struct PositionProjectJob : IJobParallelFor
    {
        [NativeDisableParallelForRestriction]
        public NativeArray<float2> positions;

        [ReadOnly]
        public NativeArray<BodyData> bodies;

        public float particleRadius;
        public float2 halfBounds;
        public float percent;

        [ReadOnly]
        public NativeArray<float4> sdf;

        public int2 sdfRes;
        public float2 invWorldPerTexel;
        public float2 sdfCenter;

        [ReadOnly]
        public NativeArray<bool> isStatic;

        public void Execute(int p)
        {
            if (isStatic[p])
                return;

            float2 pos = positions[p];

            for (int i = 0; i < bodies.Length; i++)
            {
                BodyData body = bodies[i];
                float2 delta = pos - (body.com + body.offsetWS);

                if (body.shape == Shape.Circle)
                {
                    float minDist = body.radius + particleRadius;
                    float distSq = delta.x * delta.x + delta.y * delta.y;
                    if (distSq >= minDist * minDist)
                        continue;

                    float dist = math.sqrt(distSq);
                    float2 normal = dist > 1E-06f ? delta / dist : new float2(0f, 1f);
                    pos += normal * ((minDist - dist) * percent);
                }
                else if (math.lengthsq(delta) <= Square(body.boundRadius + particleRadius)
                         && BoxContact(in body, delta, particleRadius, out float2 normal, out _, out float penetration) && penetration > 0f)
                {
                    pos += normal * (penetration * percent);
                }
            }

            SampleSDF(pos, in sdf, sdfRes, halfBounds, invWorldPerTexel, sdfCenter, out float phi, out float2 sdfNormal);
            if (phi < particleRadius)
                pos += sdfNormal * ((particleRadius - phi) * percent);

            float2 limit = halfBounds - particleRadius;
            pos.x = math.clamp(pos.x, -limit.x, limit.x);
            pos.y = math.clamp(pos.y, LowerBound(limit.y, sdfCenter.y), UpperBound(limit.y, sdfCenter.y));
            positions[p] = pos;
        }
    }

    private FluidSolver solver;

    public float fixedDeltaTime = 0.005f;

    [Range(0f, 1f)]
    public float surfaceFriction = 1f;

    public int positionIterations;

    public float slop = 0.05f;

    public Vector2 halfBounds;

    private readonly List<BodyInfo> bodies = new List<BodyInfo>();

    private float accumulator;

    public SDFCollider SDFCollider;

    private NativeArray<float4> _sdfField;
    private int2 _sdfRes;
    private float2 _invWorldPerTexel;
    private float2 _sdfCenter;

    private Unity.Mathematics.Random _rng;

    public float particleCollisionRadius = 1f;

    [Tooltip("Số bước mô phỏng tối đa mỗi frame, chặn vòng lặp tụt FPS.")]
    [Range(1f, 10f)]
    public int maxStepsPerFrame = 5;

    private void Awake()
    {
        _rng = new Unity.Mathematics.Random((uint)(Time.frameCount + 1));
    }

    public void Init()
    {
        solver = GetComponent<FluidSolver>();

        Level level = Singleton<GameManager>.Instance.level;
        if (level != null)
            halfBounds = new Vector2(level.levelWidth * 0.5f, level.TotalLevelHeight * 0.5f);

        RefreshBodies();

        SDFCollider.Init(this);
        _sdfCenter = SDFCollider.sdfCenter;
        RegisterSDF(SDFCollider.outputSDF);

        Physics2D.simulationMode = SimulationMode2D.Script;
    }

    private void Shuffle<T>(IList<T> list)
    {
        for (int i = list.Count - 1; i >= 1; i--)
        {
            int j = _rng.NextInt(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    public void RegisterSDF(RenderTexture rt)
    {
        // Decompiled as `width = rt.width; width = rt.height;` - the width was overwritten,
        // so the resolution came out square (1024x1024 for a 245x1024 texture) and
        // invWorldPerTexel was 4.18x too large. SampleSDF then read the field at the wrong
        // stride and reported "no geometry" everywhere: the fluid fell through the level.
        if (_sdfField.IsCreated)
            _sdfField.Dispose();

        int width = rt.width;
        int height = rt.height;

        _sdfField = new NativeArray<float4>(width * height, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
        AsyncGPUReadback.RequestIntoNativeArray(ref _sdfField, rt).WaitForCompletion();

        _sdfRes = new int2(width, height);

        // SampleSDF multiplies (worldPos - center + halfBounds) by this, so it is
        // texels per world unit on each axis.
        _invWorldPerTexel = new float2(width / (halfBounds.x * 2f), height / (halfBounds.y * 2f));
    }

    // Box test against the box inflated by the particle radius. Returns true when the particle
    // is inside it; the push-out normal is the face normal of the least-penetrated axis.
    private static float Square(float x) => x * x;

    private static bool BoxContact(in BodyData body, float2 delta, float particleRadius, out float2 normal, out float2 leverArm, out float penetration)
    {
        float2 local = math.mul(math.transpose(body.R), delta);
        float2 q = math.abs(local) - (body.halfExtents + particleRadius);
        float outside = math.length(math.max(q, 0f));
        float inside = math.min(math.max(q.x, q.y), 0f);
        float signedDist = outside + inside;

        if (signedDist > 0f)
        {
            normal = float2.zero;
            leverArm = float2.zero;
            penetration = 0f;
            return false;
        }

        float2 normalLocal = q.x > q.y
            ? new float2(local.x >= 0f ? 1f : -1f, 0f)
            : new float2(0f, local.y >= 0f ? 1f : -1f);

        normal = math.mul(body.R, normalLocal);
        leverArm = math.mul(body.R, math.clamp(local, -body.halfExtents, body.halfExtents)) + body.offsetWS;
        penetration = -signedDist;
        return true;
    }

    // Vertical level box. It was centred on the world origin, so on levels deeper than half their
    // height (e.g. level 6, sections down to y = -22) the lower sections were outside the box and the
    // fluid could never reach them. The SDF is centred on the level, so the box now also extends down
    // to the level's bottom; the top keeps the old extent so fluid still spawns above the view.
    private static float LowerBound(float halfLimit, float centerY) => math.min(-halfLimit, centerY - halfLimit);

    private static float UpperBound(float halfLimit, float centerY) => math.max(halfLimit, centerY + halfLimit);

    private static void SampleSDF(float2 worldPos, in NativeArray<float4> field, int2 res, float2 halfBounds, float2 invWorldPerTexel, float2 sdfCenter, out float phi, out float2 n)
    {
        float2 texCoord = (worldPos - sdfCenter + halfBounds) * invWorldPerTexel;
        int x0 = (int)math.floor(texCoord.x);
        int y0 = (int)math.floor(texCoord.y);

        if (x0 < 0 || y0 < 0 || x0 >= res.x - 1 || y0 >= res.y - 1)
        {
            phi = 1000000f;
            n = new float2(0f, 1f);
            return;
        }

        float fx = texCoord.x - x0;
        float fy = texCoord.y - y0;

        float c00 = field[y0 * res.x + x0].x;
        float c10 = field[y0 * res.x + x0 + 1].x;
        float c01 = field[(y0 + 1) * res.x + x0].x;
        float c11 = field[(y0 + 1) * res.x + x0 + 1].x;

        float top = c00 + fx * (c10 - c00);
        float bottom = c01 + fx * (c11 - c01);
        phi = (halfBounds.y + halfBounds.y) * (top + fy * (bottom - top));

        float gx = halfBounds.y * (c10 - c00 + c11 - c01);
        float gy = halfBounds.y * (c01 - c00 + c11 - c10);
        float lenSq = gx * gx + gy * gy;
        if (lenSq <= 1E-12f)
        {
            n = new float2(0f, 1f);
            return;
        }

        float invLen = 1f / math.sqrt(lenSq);
        n = new float2(gx * invLen, gy * invLen);
    }

    public void RefreshBodies()
    {
        bodies.Clear();

        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager == null || gameManager.level == null)
            return;

        foreach (Rigidbody2D rb in gameManager.level.GetComponentsInChildren<Rigidbody2D>(false))
        {
            if (rb == null || !rb.simulated)
                continue;

            CircleCollider2D circle = rb.GetComponent<CircleCollider2D>();
            BoxCollider2D box = rb.GetComponent<BoxCollider2D>();
            if (circle == null && box == null)
                continue;

            if (box)
            {
                Block block = rb.GetComponent<Block>();
                if (block != null && block.isCleared)
                    continue;
            }

            BodyInfo info = new BodyInfo { body = rb };
            if (circle != null)
            {
                Vector3 scale = circle.transform.lossyScale;
                info.shape = Shape.Circle;
                info.radiusWS = circle.radius * Mathf.Max(Mathf.Abs(scale.x), Mathf.Abs(scale.y));
            }
            else
            {
                Vector3 scale = box.transform.lossyScale;
                Vector2 size = box.size;
                info.shape = Shape.Box;
                info.halfExtentsLS = new float2(size.x * 0.5f * Mathf.Abs(scale.x), size.y * 0.5f * Mathf.Abs(scale.y));
                info.localOffset = box.offset;
            }

            bodies.Add(info);
        }
    }

    private void Update()
    {
        accumulator += Time.deltaTime;

        int steps = 0;
        while (accumulator >= fixedDeltaTime && steps < maxStepsPerFrame)
        {
            Step(fixedDeltaTime);
            accumulator -= fixedDeltaTime;
            steps++;
        }

        if (steps == maxStepsPerFrame)
            accumulator = Mathf.Min(accumulator, fixedDeltaTime);
    }

    private void Step(float dt)
    {
        if (solver == null)
            return;

        for (int i = bodies.Count - 1; i >= 0; i--)
        {
            if (bodies[i].body == null || !bodies[i].body.simulated)
                bodies.RemoveAt(i);
        }

        solver.Step(dt);
        Shuffle(bodies);

        NativeArray<float2> positions = solver.positions;
        EnsureBodyBuffers(bodies.Count);
        NativeArray<BodyData> bodyData = _bodyData.GetSubArray(0, bodies.Count);

        for (int i = 0; i < bodies.Count; i++)
        {
            BodyInfo info = bodies[i];
            Rigidbody2D body = info.body;

            float angle = -body.rotation * Mathf.Deg2Rad;
            float cos = Mathf.Cos(angle);
            float sin = Mathf.Sin(angle);
            float2x2 rotation = new float2x2(cos, sin, -sin, cos);

            bool isDynamic = body.bodyType == RigidbodyType2D.Dynamic;

            bodyData[i] = new BodyData
            {
                shape = info.shape,
                com = body.worldCenterOfMass,
                R = rotation,
                halfExtents = info.halfExtentsLS,
                radius = info.radiusWS,
                invMass = isDynamic ? 1f / body.mass : 0f,
                invInertia = isDynamic ? 1f / body.inertia : 0f,
                vel = body.velocity,
                angVel = body.angularVelocity * Mathf.Deg2Rad,
                offsetWS = info.shape == Shape.Box ? math.mul(rotation, (float2)info.localOffset) : float2.zero,
                isKinematic = !isDynamic,
                boundRadius = info.shape == Shape.Box ? math.length(info.halfExtentsLS) : info.radiusWS
            };
        }

        NativeArray<ForceBundle> forces = _forces.GetSubArray(0, bodies.Count);

        CouplerJob couplerJob = new CouplerJob
        {
            positions = positions,
            velocities = solver.velocities,
            bodies = bodyData,
            result = forces,
            isStatic = solver.isStatic,
            invFluidMass = solver.particleMass > 0f ? 1f / solver.particleMass : 0f,
            restitution = surfaceFriction,
            dt = dt,
            particleRadius = particleCollisionRadius,
            mu = surfaceFriction,
            halfBounds = halfBounds,
            sdf = _sdfField,
            sdfRes = _sdfRes,
            invWorldPerTexel = _invWorldPerTexel,
            sdfCenter = _sdfCenter
        };
        couplerJob.Schedule(solver.ActiveCount, 64).Complete();

        for (int i = 0; i < bodies.Count; i++)
        {
            Rigidbody2D body = bodies[i].body;
            if (body.bodyType != RigidbodyType2D.Dynamic)
                continue;

            ForceBundle bundle = forces[i];
            body.AddForce(bundle.force, ForceMode2D.Force);
            body.AddTorque(bundle.torque, ForceMode2D.Force);
        }

        for (int i = 0; i < forces.Length; i++)
            forces[i] = default;

        if (positionIterations >= 1)
        {
            PositionProjectJob projectJob = new PositionProjectJob
            {
                positions = positions,
                bodies = bodyData,
                particleRadius = particleCollisionRadius,
                halfBounds = halfBounds,
                percent = 0.2f,
                sdf = _sdfField,
                sdfRes = _sdfRes,
                invWorldPerTexel = _invWorldPerTexel,
                sdfCenter = _sdfCenter,
                isStatic = solver.isStatic
            };

            for (int k = 0; k < positionIterations; k++)
                projectJob.Schedule(solver.ActiveCount, 64).Complete();
        }

        Physics2D.Simulate(dt);
    }

    // Body buffers are kept between steps (the coupler steps 3-5 times per frame) and only grow.
    private NativeArray<BodyData> _bodyData;
    private NativeArray<ForceBundle> _forces;

    private void EnsureBodyBuffers(int count)
    {
        if (_bodyData.IsCreated && _bodyData.Length >= count)
            return;

        int size = Mathf.Max(16, Mathf.NextPowerOfTwo(count));
        if (_bodyData.IsCreated) _bodyData.Dispose();
        if (_forces.IsCreated) _forces.Dispose();
        _bodyData = new NativeArray<BodyData>(size, Allocator.Persistent);
        _forces = new NativeArray<ForceBundle>(size, Allocator.Persistent);
    }

    private void OnDestroy()
    {
        if (_bodyData.IsCreated) _bodyData.Dispose();
        if (_forces.IsCreated) _forces.Dispose();
        if (_sdfField.IsCreated)
            _sdfField.Dispose();
    }
}
