using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

public class FluidSolver : MonoBehaviour
{

    private struct PowerUpMergeData
    {
        public int partner;
        public float startTime;
    }

    public bool isClumped;
    public int maxParticles;
    public int maxTypeBatches;
    public int colorFluidTypes;
    public int mudFluidType;
    public int snowFluidType;
    public int honeyFluidType;
    public HashSet<int> usedFluidTypes;

    [UnityEngine.Space(5f)]
    public float viscosityStrength;
    public float pressureMultiplier;
    public float nearPressureMultiplier;
    public float targetDensity;
    public float buoyancyStrength;
    public float waterReactionMultiplier;
    public float splashDownStrength;
    public int powerUpThreshold;
    public int bigPowerUpThreshold;
    public float particleRadius;
    public float particleMass;
    public float alphaFadePerSecond;

    [UnityEngine.Header("Multi-fluid")]
    public float interFluidRepelStrength;
    public float honeyRepelStrength;
    public float clumpRepelStrength;

    [UnityEngine.Header("Explosion Settings")]
    public float destroyBandThickness;
    public float destroyRadius;
    public float destroyDuration;
    public float chargeDuration;

    [UnityEngine.Header("Chain Reaction Settings")]
    public float chainDelay;

    private int _activeCount;
    private float _lastStepWallTime;
    private float _lastStepDt;

    public Unity.Collections.NativeArray<Unity.Mathematics.float2> positions;
    public Unity.Collections.NativeArray<Unity.Mathematics.float2> positionsPrev;
    public Unity.Collections.NativeArray<Unity.Mathematics.float2> predicted;
    public Unity.Collections.NativeArray<Unity.Mathematics.float2> velocities;
    public Unity.Collections.NativeArray<Unity.Mathematics.float2> densities;
    public Unity.Collections.NativeArray<Unity.Mathematics.float2> deltaVel;
    public Unity.Collections.NativeArray<Unity.Mathematics.float2> gravities;
    public Unity.Collections.NativeArray<int> particleTypes;
    public Unity.Collections.NativeArray<int> particleIds;
    public Unity.Collections.NativeArray<int> powerUpIds;
    public Unity.Collections.NativeArray<int> fishIds;
    public Unity.Collections.NativeArray<int> clumpIds;
    public Unity.Collections.NativeArray<Unity.Mathematics.float4> emissionColors;
    public Unity.Collections.NativeArray<float> scales;
    public Unity.Collections.NativeArray<bool> isSimulated;
    public Unity.Collections.NativeArray<bool> isHoneyCoated;
    public Unity.Collections.NativeArray<float> waterDensities;
    public Unity.Collections.NativeArray<float> splashImpulse;
    public Unity.Collections.NativeArray<bool> isStatic;
    public Unity.Collections.NativeArray<float> viscosityStrengths;
    public Unity.Collections.NativeArray<float> nearPressureMultipliers;

    public Unity.Collections.NativeHashMap<int,int> idToIndex;
    private Unity.Collections.NativeMultiHashMap<int,int> cellMap;
    private int capacity;
    private Unity.Jobs.JobHandle _lastJob;

    public PowerUp powerUpPrefab;
    public UnityEngine.Material[] powerUpMaterials;
    public List<PowerUp> powerUps;
    private readonly Dictionary<int,PowerUp> powerUpById;

    public Action<HashSet<int>, bool> OnRemoveHoneyCoating;
    public Action<HashSet<int>> OnAddParticles;
    public Action<HashSet<int>, bool> OnStartRemoveParticles;
    public Action<HashSet<int>, UnityEngine.Vector2> OnCreatePowerup;
    public Action<bool, UnityEngine.Vector2> OnRemoveRegionStart;
    public Action<HashSet<int>, int> OnRemoveRegionComplete;
    public Action<PowerUp> OnDetonatePowerUp;

    private readonly Queue<int> explosionQueue;
    private bool isProcessing;

    [UnityEngine.Header("Power-ups")]
    public float powerUpCohesionRadius;
    public float powerUpSpringStrength;
    public float clumpCohesionRadius;
    public float clumpSpringStrength;

    [UnityEngine.Header("Fish")]
    public float fishCohesionRadius;
    public float fishSpringStrength;

    [UnityEngine.Header("Octopi")]
    public float octopusHeadCohesionRadius;
    public float octopusHeadSpringStrength;
    public int octopusHeadParticleCount;
    public float octopusBodyCohesionForce;
    public Unity.Collections.NativeArray<int> octopusIds;
    public Unity.Collections.NativeArray<bool> inOctopusHead;
    public List<Octopus> octopi;
    private Unity.Collections.NativeArray<bool> regionHasHead;

    public Unity.Collections.NativeArray<int> caterpillarIds;
    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> caterpillarMidpoints;
    public List<Caterpillar> caterpillars;
    public Unity.Collections.NativeArray<int> beeIds;
    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> beeMidpoints;
    public List<Bee> bees;

    [UnityEngine.Header("Sponges")]
    public List<Sponge> sponges;
    public Unity.Collections.NativeArray<int> spongeIds;
    public float spongeCohesionRadius;
    public float spongeSpringStrength;
    public Unity.Collections.NativeArray<bool> isWater;

    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> powerUpMidpoints;
    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> fishMidpoints;
    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> clumpMidpoints;
    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> spongeMidpoints;
    public Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> octopusHeadMidpoints;

    private Unity.Collections.NativeArray<int> octUFParent;
    private Unity.Collections.NativeArray<byte> octComponentHasHead;
    private readonly HashSet<int> _pendingRemovalIds;
    private Unity.Collections.NativeHashMap<ulong,byte> ignorePairs;

    [UnityEngine.Header("Power-up Merging")]
    public float powerUpMergeDistance;
    public float mergeDuration;
    private readonly Dictionary<int,PowerUpMergeData> merging;
    private Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> mergeDeltas;
    public readonly HashSet<int> exploding;

    public List<Honey> honeys;
    public FluidCompute compute;
    public List<Clump> clumps;

    [UnityEngine.Header("Fish Blob")]
    public Fish fishPrefab;
    public UnityEngine.Material fishMaterial;
    public List<Fish> fishes;
    public Unity.Mathematics.float2 defaultGravity;
    public Unity.Mathematics.float2 fishGravity;
    private float _nextFishZ;
    public Action OnStep;
    public Mud mudInstance;
    public Snow snowInstance;
    public float splashDestroyRadius;
    public const float goldenConstant = 137.508f;

    private IEnumerator rejectFlash;

    public int ActiveCount
    {
        get => _activeCount;
        private set => _activeCount = value;
    }

    public float lastStepWallTime
    {
        get => _lastStepWallTime;
        private set => _lastStepWallTime = value;
    }

    public float lastStepDt
    {
        get => _lastStepDt;
        private set => _lastStepDt = value;
    }

    private static ulong PairKey(int a, int b)
    {
        unchecked
        {
            return ((ulong)(uint)a << 32) | (uint)b;
        }
    }

    private static object GetCollectionManagerInstance()
    {
        var flags = System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.FlattenHierarchy;
        for (Type t = typeof(CollectionManager); t != null; t = t.BaseType)
        {
            var p = t.GetProperty("Instance", flags);
            if (p != null)
            {
                try { return p.GetValue(null, null); } catch { }
            }
            var f = t.GetField("Instance", flags);
            if (f != null)
            {
                try { return f.GetValue(null); } catch { }
            }
        }
        return null;
    }

    private static T TryInstantiateCollectionPrefab<T>(UnityEngine.Transform parent) where T : UnityEngine.Object
    {
        object manager = GetCollectionManagerInstance();
        if (manager == null) return null;
        var flags = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic;
        foreach (var f in manager.GetType().GetFields(flags))
        {
            if (!typeof(T).IsAssignableFrom(f.FieldType)) continue;
            if (f.GetValue(manager) is T prefab && prefab != null)
                return UnityEngine.Object.Instantiate(prefab, parent);
        }
        foreach (var p in manager.GetType().GetProperties(flags))
        {
            if (!p.CanRead || !typeof(T).IsAssignableFrom(p.PropertyType)) continue;
            if (p.GetValue(manager, null) is T prefab && prefab != null)
                return UnityEngine.Object.Instantiate(prefab, parent);
        }
        return null;
    }

    private static void NotifyBeeCollected(UnityEngine.Vector2 position)
    {
        object manager = GetCollectionManagerInstance();
        if (manager == null) return;
        var m = manager.GetType().GetMethod("OnCollectBee", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic, null, new[] { typeof(UnityEngine.Vector2) }, null);
        m?.Invoke(manager, new object[] { position });
    }

    private static bool GetPowerUpIsBig(PowerUp powerUp)
    {
        if (powerUp == null) return false;
        const System.Reflection.BindingFlags flags = System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic;
        var field = powerUp.GetType().GetField("isBig", flags) ?? powerUp.GetType().GetField("IsBig", flags);
        if (field != null && field.FieldType == typeof(bool)) return (bool)field.GetValue(powerUp);
        var property = powerUp.GetType().GetProperty("isBig", flags) ?? powerUp.GetType().GetProperty("IsBig", flags);
        if (property != null && property.PropertyType == typeof(bool) && property.CanRead) return (bool)property.GetValue(powerUp, null);
        return false;
    }

    private static bool TryInvokeInit(object instance, params object[] args)
    {
        if (instance == null) return false;
        var methods = instance.GetType().GetMethods(System.Reflection.BindingFlags.Instance |
                                                    System.Reflection.BindingFlags.Public |
                                                    System.Reflection.BindingFlags.NonPublic);
        foreach (var method in methods)
        {
            if (method.Name != "Init") continue;
            var parameters = method.GetParameters();
            if (parameters.Length != args.Length) continue;
            bool compatible = true;
            for (int i = 0; i < parameters.Length; ++i)
            {
                if (args[i] == null)
                {
                    if (parameters[i].ParameterType.IsValueType) { compatible = false; break; }
                }
                else if (!parameters[i].ParameterType.IsInstanceOfType(args[i]) &&
                         !(parameters[i].ParameterType.IsValueType && args[i].GetType() == parameters[i].ParameterType))
                {
                    compatible = false;
                    break;
                }
            }
            if (!compatible) continue;
            try
            {
                method.Invoke(instance, args);
                return true;
            }
            catch { }
        }
        return false;
    }

    public void LastJobComplete()
    {
        _lastJob.Complete();
    }

    private static int NextPowerOfTwo(int value)
    {
        int p = 1;
        while (p < value && p > 0) p <<= 1;
        return p > 0 ? p : value;
    }

    private void Awake()
    {
        maxParticles = Math.Max(1, maxParticles);
        if (usedFluidTypes == null) usedFluidTypes = new HashSet<int>();

        positions = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        positionsPrev = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        predicted = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        velocities = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        densities = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        deltaVel = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        gravities = new Unity.Collections.NativeArray<Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        particleTypes = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        particleIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        powerUpIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        fishIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        clumpIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        octopusIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        caterpillarIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        beeIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        spongeIds = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent);
        emissionColors = new Unity.Collections.NativeArray<Unity.Mathematics.float4>(maxParticles, Unity.Collections.Allocator.Persistent);
        scales = new Unity.Collections.NativeArray<float>(maxParticles, Unity.Collections.Allocator.Persistent);
        isSimulated = new Unity.Collections.NativeArray<bool>(maxParticles, Unity.Collections.Allocator.Persistent);
        inOctopusHead = new Unity.Collections.NativeArray<bool>(maxParticles, Unity.Collections.Allocator.Persistent);
        regionHasHead = new Unity.Collections.NativeArray<bool>(maxParticles, Unity.Collections.Allocator.Persistent);
        isWater = new Unity.Collections.NativeArray<bool>(maxParticles, Unity.Collections.Allocator.Persistent);
        isHoneyCoated = new Unity.Collections.NativeArray<bool>(maxParticles, Unity.Collections.Allocator.Persistent);
        isStatic = new Unity.Collections.NativeArray<bool>(maxParticles, Unity.Collections.Allocator.Persistent);
        waterDensities = new Unity.Collections.NativeArray<float>(maxParticles, Unity.Collections.Allocator.Persistent);
        splashImpulse = new Unity.Collections.NativeArray<float>(maxParticles, Unity.Collections.Allocator.Persistent);
        viscosityStrengths = new Unity.Collections.NativeArray<float>(maxParticles, Unity.Collections.Allocator.Persistent);
        nearPressureMultipliers = new Unity.Collections.NativeArray<float>(maxParticles, Unity.Collections.Allocator.Persistent);

        idToIndex = new Unity.Collections.NativeHashMap<int,int>(maxParticles, Unity.Collections.Allocator.Persistent);
        capacity = NextPowerOfTwo(maxParticles);
        cellMap = new Unity.Collections.NativeMultiHashMap<int,int>(capacity, Unity.Collections.Allocator.Persistent);
        powerUpMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        fishMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        caterpillarMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        beeMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        clumpMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        spongeMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        octopusHeadMidpoints = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        ignorePairs = new Unity.Collections.NativeHashMap<ulong,byte>(128, Unity.Collections.Allocator.Persistent);
        mergeDeltas = new Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2>(128, Unity.Collections.Allocator.Persistent);
        octUFParent = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent, Unity.Collections.NativeArrayOptions.ClearMemory);
        octComponentHasHead = new Unity.Collections.NativeArray<byte>(maxParticles, Unity.Collections.Allocator.Persistent);

        ActiveCount = 0;
        if (colorFluidTypes > 0)
            for (int i=0; i<colorFluidTypes; ++i) usedFluidTypes.Add(i);
        usedFluidTypes.Add(mudFluidType);
        usedFluidTypes.Add(snowFluidType);
        usedFluidTypes.Add(honeyFluidType);
    }

    private void OnDestroy()
    {
        _lastJob.Complete();
        Dispose(ref positions); Dispose(ref positionsPrev); Dispose(ref predicted); Dispose(ref velocities);
        Dispose(ref densities); Dispose(ref deltaVel); Dispose(ref gravities); Dispose(ref particleTypes);
        Dispose(ref particleIds); Dispose(ref powerUpIds); Dispose(ref fishIds); Dispose(ref clumpIds);
        Dispose(ref octopusIds); Dispose(ref inOctopusHead); Dispose(ref regionHasHead); Dispose(ref caterpillarIds);
        Dispose(ref beeIds); Dispose(ref spongeIds); Dispose(ref emissionColors); Dispose(ref scales); Dispose(ref isSimulated);
        Dispose(ref isHoneyCoated); Dispose(ref waterDensities); Dispose(ref splashImpulse); Dispose(ref isStatic);
        Dispose(ref viscosityStrengths); Dispose(ref nearPressureMultipliers); Dispose(ref octUFParent); Dispose(ref octComponentHasHead);
        Dispose(ref idToIndex); Dispose(ref cellMap); Dispose(ref powerUpMidpoints); Dispose(ref fishMidpoints);
        Dispose(ref caterpillarMidpoints); Dispose(ref beeMidpoints); Dispose(ref clumpMidpoints); Dispose(ref spongeMidpoints);
        Dispose(ref octopusHeadMidpoints); Dispose(ref ignorePairs); Dispose(ref mergeDeltas);
    }

    private static void Dispose<T>(ref Unity.Collections.NativeArray<T> value) where T : struct
    {
        if (value.IsCreated) value.Dispose();
    }
    private static void Dispose<TKey, TValue>(
    ref Unity.Collections.NativeHashMap<TKey, TValue> value)
    where TKey : struct, IEquatable<TKey>
    where TValue : struct
{
    if (value.IsCreated)
        value.Dispose();
}

private static void Dispose<TKey, TValue>(
    ref Unity.Collections.NativeMultiHashMap<TKey, TValue> value)
    where TKey : struct, IEquatable<TKey>
    where TValue : struct
{
    if (value.IsCreated)
        value.Dispose();
}
    public void Step(float dt)
    {
			UpdatePowerUpMidpoints();
			UpdateCaterpillarMidpoints();
			UpdateBeeMidpoints();
			UpdateOctopusHeadMidpoints();
			UpdateSpongeMidpoints();
			UpdateClumpMidpoints();
			DetectPowerUpMerges();
			UpdateMergeDeltasAndFinish();
			lastStepWallTime = UnityEngine.Time.time;
			lastStepDt = dt;
			Unity.Jobs.IJobParallelForExtensions.Schedule(new PowerUpMergeTranslateJob
			{
				positions = positions,
				velocities = velocities,
				powerUpIds = powerUpIds,
				mergeDeltas = mergeDeltas,
				dt = dt
			}, ActiveCount, 64).Complete();
			Unity.Collections.NativeArray<global::Unity.Mathematics.float2>.Copy(positions, positionsPrev);
			Unity.Jobs.JobHandle dependsOn = Unity.Jobs.IJobParallelForExtensions.Schedule(new ClearDeltaJob
			{
				deltaVel = deltaVel
			}, ActiveCount, 64, default(Unity.Jobs.JobHandle));
			Unity.Jobs.JobHandle dependsOn2 = Unity.Jobs.IJobParallelForExtensions.Schedule(new PredictJob
			{
				positions = positions,
				velocities = velocities,
				predicted = predicted,
				gravities = gravities,
				isStatic = isStatic,
				dt = dt
			}, ActiveCount, 64, dependsOn);
			cellMap.Clear();
			Unity.Jobs.JobHandle dependsOn3 = Unity.Jobs.IJobParallelForExtensions.Schedule(new FixedRadiusNeighborSearchJob
			{
				positions = predicted,
				cellSize = particleRadius * 2f,
				capacity = capacity,
				cellMap = cellMap.AsParallelWriter()
			}, ActiveCount, 64, dependsOn2);
			Unity.Jobs.JobHandle dependsOn4 = Unity.Jobs.IJobParallelForExtensions.Schedule(new WaterDensityJob
			{
				predicted = predicted,
				cellMap = cellMap,
				isWater = isWater,
				waterDensities = waterDensities,
				mass = particleMass,
				capacity = capacity,
				radius = particleRadius * 2f
			}, ActiveCount, 64, dependsOn3);
			Unity.Jobs.JobHandle dependsOn5 = Unity.Jobs.IJobParallelForExtensions.Schedule(new DensityJob
			{
				predicted = predicted,
				cellMap = cellMap,
				densities = densities,
				isWater = isWater,
				ignorePairs = ignorePairs,
				powerUpIds = powerUpIds,
				mass = particleMass,
				capacity = capacity,
				radius = particleRadius * 2f
			}, ActiveCount, 64, dependsOn4);
			Unity.Jobs.JobHandle dependsOn6 = Unity.Jobs.IJobParallelForExtensions.Schedule(new PressureJob
			{
				predicted = predicted,
				densities = densities,
				cellMap = cellMap,
				particleTypes = particleTypes,
				isHoneyCoated = isHoneyCoated,
				ignorePairs = ignorePairs,
				powerUpIds = powerUpIds,
				isWater = isWater,
				clumpIds = clumpIds,
				fishIds = fishIds,
				nearPressureMultipliers = nearPressureMultipliers,
				deltaVel = deltaVel,
				interFluidRepelStr = interFluidRepelStrength,
				honeyRepelStr = honeyRepelStrength,
				clumpRepelStrength = clumpRepelStrength,
				waterReactionGlobal = waterReactionMultiplier,
				pressureMultiplier = pressureMultiplier,
				targetDensity = targetDensity,
				dt = dt,
				capacity = capacity,
				radius = particleRadius * 2f
			}, ActiveCount, 64, dependsOn5);
			Unity.Jobs.JobHandle dependsOn7 = Unity.Jobs.IJobParallelForExtensions.Schedule(new ViscosityJob
			{
				predicted = predicted,
				velocities = velocities,
				cellMap = cellMap,
				particleTypes = particleTypes,
				ignorePairs = ignorePairs,
				powerUpIds = powerUpIds,
				isWater = isWater,
				deltaVel = deltaVel,
				viscosityStrengths = viscosityStrengths,
				dt = dt,
				capacity = capacity,
				waterReactionGlobal = waterReactionMultiplier,
				fishIds = fishIds,
				radius = particleRadius * 2f
			}, ActiveCount, 64, dependsOn6);
			Unity.Jobs.JobHandle dependsOn8 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BuoyancyJob
			{
				waterDensities = waterDensities,
				isWater = isWater,
				fishIds = fishIds,
				deltaVel = deltaVel,
				buoyancyStrength = buoyancyStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn7);
			Unity.Jobs.JobHandle dependsOn9 = Unity.Jobs.IJobParallelForExtensions.Schedule(new SplashDownJob
			{
				predicted = predicted,
				isWater = isWater,
				cellMap = cellMap,
				deltaVel = deltaVel,
				splashDownStrength = splashDownStrength,
				capacity = capacity,
				dt = dt,
				radius = particleRadius * 2f
			}, ActiveCount, 64, dependsOn8);
			Unity.Jobs.JobHandle dependsOn10 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				blobIds = fishIds,
				blobMidpoints = fishMidpoints,
				cohesionRadius = fishCohesionRadius,
				springStrength = fishSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn9);
			Unity.Jobs.JobHandle dependsOn11 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				blobIds = powerUpIds,
				blobMidpoints = powerUpMidpoints,
				cohesionRadius = powerUpCohesionRadius,
				springStrength = powerUpSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn10);
			Unity.Jobs.JobHandle dependsOn12 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				blobIds = spongeIds,
				blobMidpoints = spongeMidpoints,
				cohesionRadius = spongeCohesionRadius,
				springStrength = spongeSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn11);
			Unity.Jobs.JobHandle dependsOn13 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				blobIds = clumpIds,
				blobMidpoints = clumpMidpoints,
				cohesionRadius = clumpCohesionRadius,
				springStrength = clumpSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn12);
			Unity.Jobs.JobHandle dependsOn14 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				blobIds = fishIds,
				blobMidpoints = fishMidpoints,
				cohesionRadius = fishCohesionRadius,
				springStrength = fishSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn13);
			Unity.Jobs.JobHandle dependsOn15 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				blobIds = powerUpIds,
				blobMidpoints = powerUpMidpoints,
				cohesionRadius = powerUpCohesionRadius,
				springStrength = powerUpSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn14);
			Unity.Jobs.JobHandle jobHandle = Unity.Jobs.IJobParallelForExtensions.Schedule(new OctopusHeadCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				octopusIds = octopusIds,
				inOctopusHead = inOctopusHead,
				octopusMidpoints = octopusHeadMidpoints,
				headCohesionRadius = octopusHeadCohesionRadius,
				headSpringStrength = octopusHeadSpringStrength,
				dt = dt
			}, ActiveCount, 64, dependsOn15);
			Unity.Jobs.JobHandle jobHandle2 = Unity.Jobs.IJobParallelForExtensions.Schedule(new OctUF_InitJob
			{
				parent = octUFParent
			}, ActiveCount, 64, default(Unity.Jobs.JobHandle));
			Unity.Jobs.JobHandle dependsOn16 = Unity.Jobs.IJobParallelForExtensions.Schedule(new ClearByteJob
			{
				array = octComponentHasHead
			}, ActiveCount, 64, default(Unity.Jobs.JobHandle));
			Unity.Jobs.JobHandle octUfPreparation = Unity.Jobs.JobHandle.CombineDependencies(jobHandle2, dependsOn16);
			Unity.Jobs.JobHandle dependsOn17 = Unity.Jobs.IJobParallelForExtensions.Schedule(new OctUF_FlagHeadJob
			{
				parent = octUFParent,
				isHead = inOctopusHead.Reinterpret<byte>(),
				componentHasHead = octComponentHasHead
			}, ActiveCount, 64, octUfPreparation);
			Unity.Jobs.JobHandle dependsOn18 = Unity.Jobs.IJobParallelForExtensions.Schedule(new OctUF_WriteRegionJob
			{
				parent = octUFParent,
				componentHasHead = octComponentHasHead,
				regionHasHead = regionHasHead
			}, ActiveCount, 64, dependsOn17);
			Unity.Jobs.JobHandle jobHandle3 = Unity.Jobs.IJobParallelForExtensions.Schedule(new OctopusBodyCohesionJob
			{
				positions = positions,
				deltaVel = deltaVel,
				regionHasHead = regionHasHead,
				octopusIds = octopusIds,
				octopusHeadMidpoints = octopusHeadMidpoints,
				bodyCohesionForce = octopusBodyCohesionForce,
				dt = dt
			}, ActiveCount, 64, dependsOn18);
			Unity.Jobs.JobHandle dependsOn19 = jobHandle3;
			Unity.Jobs.JobHandle jobHandle4 = Unity.Jobs.IJobParallelForExtensions.Schedule(new IntegrateJob
			{
				positions = positions,
				velocities = velocities,
				isStatic = isStatic,
				dt = dt
			}, ActiveCount, 64, dependsOn19);
			_lastJob.Complete();
			_lastJob = jobHandle4;
			global::System.Action onStep = OnStep;
			if (OnStep != null)
			{
				onStep();
			}
    }

    public HashSet<int> AddParticles(Unity.Mathematics.float2[] spawnPositions, int type, Action<ParticleInitData> onInit = null)
    {
        var addedIds = new HashSet<int>();
        if (spawnPositions == null || spawnPositions.Length == 0) return addedIds;
        _lastJob.Complete();

        int count = Math.Min(spawnPositions.Length, maxParticles - ActiveCount);
        if (count <= 0) return addedIds;

        int start = ActiveCount;
        for (int i=0; i<count; ++i)
        {
            int index = start + i;
            Unity.Mathematics.float2 p = spawnPositions[i];
            int id = IdGenerator.Next();

            positions[index] = p;
            positionsPrev[index] = p;
            predicted[index] = p;
            velocities[index] = Unity.Mathematics.float2.zero;
            densities[index] = Unity.Mathematics.float2.zero;
            deltaVel[index] = Unity.Mathematics.float2.zero;
            gravities[index] = defaultGravity;
            particleTypes[index] = type;
            particleIds[index] = id;
            powerUpIds[index] = -1;
            fishIds[index] = -1;
            clumpIds[index] = -1;
            octopusIds[index] = -1;
            caterpillarIds[index] = -1;
            beeIds[index] = -1;
            spongeIds[index] = -1;
            inOctopusHead[index] = false;
            isWater[index] = false;
            isHoneyCoated[index] = false;
            isStatic[index] = false;
            isSimulated[index] = true;
            scales[index] = 1f;
            waterDensities[index] = 0f;
            splashImpulse[index] = 0f;
            viscosityStrengths[index] = viscosityStrength;
            nearPressureMultipliers[index] = nearPressureMultiplier;
            emissionColors[index] = Unity.Mathematics.float4.zero;

            idToIndex.TryAdd(id, index);
            addedIds.Add(id);
            onInit?.Invoke(new ParticleInitData(index, id, i));
        }

        ActiveCount = start + count;
        OnAddParticles?.Invoke(addedIds);
        return addedIds;
    }

    public int FindClosestParticle(UnityEngine.Vector2 worldPos, float maxRadius)
    {
        if (ActiveCount <= 0) return -1;
        float maxSq = maxRadius * maxRadius;
        float bestSq = maxSq;
        int best = -1;
        var target = new Unity.Mathematics.float2(worldPos.x, worldPos.y);
        for (int i=0; i<ActiveCount; ++i)
        {
            if (isWater[i]) continue;
            var d = positions[i] - target;
            float dsq = Unity.Mathematics.math.lengthsq(d);
            if (dsq <= bestSq) { bestSq = dsq; best = i; }
        }
        return best;
    }

    public HashSet<int> FindContiguousRegionIndices(int seedIndex)
    {
        var result = new HashSet<int>();
        if (seedIndex < 0 || seedIndex >= ActiveCount) return result;
        int seedType = particleTypes[seedIndex];
        bool seedHoney = isHoneyCoated[seedIndex];
        float threshold = Math.Max(0.0001f, particleRadius * 2f);
        float thresholdSq = threshold * threshold;
        var queue = new Queue<int>();
        result.Add(seedIndex);
        queue.Enqueue(seedIndex);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            var p = positions[current];
            for (int i=0; i<ActiveCount; ++i)
            {
                if (result.Contains(i) || particleTypes[i] != seedType || isHoneyCoated[i] != seedHoney) continue;
                if (Unity.Mathematics.math.lengthsq(positions[i] - p) <= thresholdSq)
                {
                    result.Add(i);
                    queue.Enqueue(i);
                }
            }
        }
        return result;
    }

    public List<HashSet<int>> FindContiguousRegions(HashSet<int> ids)
    {
        var regions = new List<HashSet<int>>();
        if (ids == null || ids.Count == 0) return regions;
        var remaining = new HashSet<int>(ids);
        while (remaining.Count > 0)
        {
            int id = remaining.First();
            if (!idToIndex.TryGetValue(id, out int seedIndex))
            {
                remaining.Remove(id);
                continue;
            }
            var regionIndices = FindContiguousRegionIndices(seedIndex);
            var regionIds = new HashSet<int>();
            foreach (int idx in regionIndices)
            {
                int pid = particleIds[idx];
                if (remaining.Contains(pid)) regionIds.Add(pid);
            }
            if (regionIds.Count == 0) regionIds.Add(id);
            regions.Add(regionIds);
            foreach (int rid in regionIds) remaining.Remove(rid);
        }
        return regions;
    }

    public void UserRemoveRegion(HashSet<int> ids, int touchId, UnityEngine.Vector2 wPos, float delay = 0.3f)
    {
        if (ids == null || ids.Count == 0) return;
        var regions = FindContiguousRegions(ids);
        foreach (var region in regions)
        {
            var fresh = new HashSet<int>();
            foreach (int id in region)
                if (_pendingRemovalIds.Add(id)) fresh.Add(id);
            if (fresh.Count == 0) continue;

            bool createPowerup = fresh.Count >= (isClumped ? 16 : powerUpThreshold);
            bool isBig = createPowerup && fresh.Count > bigPowerUpThreshold;
            OnRemoveRegionStart?.Invoke(createPowerup, wPos);
            if (createPowerup) OnCreatePowerup?.Invoke(fresh, wPos);

            HandleSplashDestroy(fresh);
            Action<HashSet<int>> onRemove = removed =>
            {
                foreach (int id in removed) _pendingRemovalIds.Remove(id);
                if (createPowerup) AddPowerUp(new Unity.Mathematics.float2(wPos.x, wPos.y), 0, isBig);
                OnRemoveRegionComplete?.Invoke(removed, touchId);
            };
            StartCoroutine(HandleRemove(fresh, onRemove, !createPowerup, delay));
        }
    }

    private IEnumerator HandleRemove(HashSet<int> ids, Action<HashSet<int>> onRemove = null, bool explode = true, float delay = 0.2f)
    {
        if (ids == null || ids.Count == 0) yield break;
        _lastJob.Complete();
        OnStartRemoveParticles?.Invoke(ids, explode);
        foreach (int id in ids)
            if (idToIndex.TryGetValue(id, out int index)) scales[index] = 0f;
        if (delay > 0f) yield return new UnityEngine.WaitForSeconds(delay);
        RemoveParticles(ids, onRemove);
    }

    public void RemoveParticles(HashSet<int> ids, Action<HashSet<int>> onRemove = null)
    {
        if (ids == null || ids.Count == 0 || ActiveCount <= 0) return;
        _lastJob.Complete();
        var indices = new List<int>(ids.Count);
        foreach (int id in ids)
            if (idToIndex.TryGetValue(id, out int idx)) indices.Add(idx);
        indices.Sort((a,b) => b.CompareTo(a));

        foreach (int index in indices)
        {
            if (index < 0 || index >= ActiveCount) continue;
            int last = ActiveCount - 1;
            if (index != last)
            {
                positions[index] = positions[last];
                positionsPrev[index] = positionsPrev[last];
                predicted[index] = predicted[last];
                velocities[index] = velocities[last];
                densities[index] = densities[last];
                deltaVel[index] = deltaVel[last];
                gravities[index] = gravities[last];
                particleTypes[index] = particleTypes[last];
                particleIds[index] = particleIds[last];
                powerUpIds[index] = powerUpIds[last];
                fishIds[index] = fishIds[last];
                clumpIds[index] = clumpIds[last];
                octopusIds[index] = octopusIds[last];
                inOctopusHead[index] = inOctopusHead[last];
                caterpillarIds[index] = caterpillarIds[last];
                beeIds[index] = beeIds[last];
                spongeIds[index] = spongeIds[last];
                emissionColors[index] = emissionColors[last];
                scales[index] = scales[last];
                isSimulated[index] = isSimulated[last];
                isHoneyCoated[index] = isHoneyCoated[last];
                waterDensities[index] = waterDensities[last];
                splashImpulse[index] = splashImpulse[last];
                isStatic[index] = isStatic[last];
                viscosityStrengths[index] = viscosityStrengths[last];
                nearPressureMultipliers[index] = nearPressureMultipliers[last];

                int movedId = particleIds[index];
                idToIndex[movedId] = index;
            }
            int removedId = particleIds[last];
            idToIndex.Remove(removedId);
            ActiveCount = last;
        }
        onRemove?.Invoke(ids);
    }

    public int GetNextUnusedFluidType()
    {
        if (usedFluidTypes == null) usedFluidTypes = new HashSet<int>();
        int type = 0;
        while (usedFluidTypes.Contains(type)) type++;
        usedFluidTypes.Add(type);
        return type;
    }

    public Mud AddMud(Unity.Mathematics.float2[] positionsToAdd)
    {
        if (mudInstance != null) { mudInstance.AddParticles(positionsToAdd); return mudInstance; }
        HashSet<int> ids = AddParticles(positionsToAdd, mudFluidType, ctx => { });
        mudInstance = TryInstantiateCollectionPrefab<Mud>(transform);
        if (mudInstance != null) mudInstance.Init(this, ids, mudFluidType, compute);
        return mudInstance;
    }

    public Snow AddSnow(Unity.Mathematics.float2[] positionsToAdd)
    {
        if (snowInstance != null) { snowInstance.AddParticles(positionsToAdd); return snowInstance; }
        HashSet<int> ids = AddParticles(positionsToAdd, snowFluidType, ctx => { });
        snowInstance = TryInstantiateCollectionPrefab<Snow>(transform);
        if (snowInstance != null) snowInstance.Init(this, ids, snowFluidType, compute);
        return snowInstance;
    }

    public Octopus AddOctopus(Unity.Mathematics.float2[] pos, int splitIndex)
    {
        int fluidType = GetNextUnusedFluidType();
        int octId = IdGenerator.Next();
        var headIds = new HashSet<int>();
        HashSet<int> ids = AddParticles(pos, fluidType, ctx =>
        {
            octopusIds[ctx.Index] = octId;
            if (octopusHeadParticleCount > 0) { inOctopusHead[ctx.Index] = true; headIds.Add(ctx.Id); }
        });
        Octopus octopus = TryInstantiateCollectionPrefab<Octopus>(transform);
        if (octopus == null) return null;
        octopus.id = octId;
        octopus.Init(this, ids, fluidType, compute);
        octopi.Add(octopus);
        octopusHeadMidpoints[octId] = GetAveragePositionFromIDs(headIds);
        return octopus;
    }

    public void RemoveOctopus(Octopus octopus)
    {
        if (octopus == null) return;
        usedFluidTypes.Remove(octopus.fluidType);
        octopus.OnSolverRemoveParticlesStart(octopus.particleIds, false);
        RemoveParticles(octopus.particleIds);
        octopusHeadMidpoints.Remove(octopus.id);
        octopi.Remove(octopus);
        if (octopus.gameObject != null) UnityEngine.Object.DestroyImmediate(octopus.gameObject);
    }

    public void RemoveCaterpillar(Caterpillar caterpillar)
    {
        if (caterpillar == null) return;
        usedFluidTypes.Remove(caterpillar.fluidType);
        caterpillar.OnSolverRemoveParticlesStart(caterpillar.particleIds, false);
        RemoveParticles(caterpillar.particleIds);
        caterpillarMidpoints.Remove(caterpillar.id);
        caterpillars.Remove(caterpillar);
        if (caterpillar.gameObject != null) UnityEngine.Object.DestroyImmediate(caterpillar.gameObject);
    }

    public void BuildOctopusRegionMap()
    {
        if (ActiveCount <= 0) return;
        for (int i=0; i<ActiveCount; ++i) regionHasHead[i] = false;
        foreach (var octopus in octopi)
        {
            if (octopus == null || octopus.particleIds == null) continue;
            var regions = FindContiguousRegions(octopus.particleIds);
            foreach (var region in regions)
            {
                bool hasHead = false;
                foreach (int id in region)
                    if (idToIndex.TryGetValue(id, out int idx) && inOctopusHead[idx]) { hasHead = true; break; }
                foreach (int id in region)
                    if (idToIndex.TryGetValue(id, out int idx)) regionHasHead[idx] = hasHead;
            }
        }
    }

    public Caterpillar AddCaterpillar(Unity.Mathematics.float2[] pos)
    {
        int type = GetNextUnusedFluidType();
        int id = IdGenerator.Next();
        HashSet<int> ids = AddParticles(pos, type, ctx => caterpillarIds[ctx.Index] = id);
        Caterpillar c = TryInstantiateCollectionPrefab<Caterpillar>(transform);
        if (c == null) return null;
        c.Init(this, ids, type, compute, id);
        caterpillars.Add(c);
        return c;
    }

    public Bee AddBee(Unity.Mathematics.float2[] pos)
    {
        int type = GetNextUnusedFluidType();
        int id = IdGenerator.Next();
        HashSet<int> ids = AddParticles(pos, type, ctx => { isHoneyCoated[ctx.Index] = true; beeIds[ctx.Index] = id; });
        Bee b = TryInstantiateCollectionPrefab<Bee>(transform);
        if (b == null) return null;
        b.Init(this, ids, type, compute, id);
        bees.Add(b);
        return b;
    }

    public void RemoveBee(Bee bee)
    {
        if (bee == null) return;
        usedFluidTypes.Remove(bee.fluidType);
        bee.OnSolverRemoveParticlesStart(bee.particleIds, false);
        RemoveParticles(bee.particleIds);
        beeMidpoints.Remove(bee.id);
        bees.Remove(bee);
        if (bee.gameObject != null) UnityEngine.Object.DestroyImmediate(bee.gameObject);
    }

    public Sponge AddSponge(Unity.Mathematics.float2[] pos)
    {
        int type = GetNextUnusedFluidType();
        int id = IdGenerator.Next();
        HashSet<int> ids = AddParticles(pos, type, ctx => spongeIds[ctx.Index] = id);
        Sponge s = TryInstantiateCollectionPrefab<Sponge>(transform);
        if (s == null) return null;
        s.Init(this, ids, type, compute, id);
        sponges.Add(s);
        return s;
    }

    public void RemoveSponge(Sponge sponge)
    {
        if (sponge == null) return;
        usedFluidTypes.Remove(sponge.fluidType);
        RemoveParticles(sponge.particleIds);
        spongeMidpoints.Remove(sponge.id);
        sponges.Remove(sponge);
        if (sponge.gameObject != null) UnityEngine.Object.Destroy(sponge.gameObject);
    }

    public Clump AddClump(Unity.Mathematics.float2[] pos, int type)
    {
        if (!isClumped)
        {
            AddParticles(pos, type);
            return default(Clump);
        }

        int clumpId = IdGenerator.Next();
        HashSet<int> particleIds = AddParticles(pos, type, ctx => clumpIds[ctx.Index] = clumpId);

        Clump clump = new Clump
        {
            id = clumpId,
            particleIds = particleIds
        };

        if (clumps == null)
            clumps = new List<Clump>();

        clumps.Add(clump);
        return clump;
    }

    public void RemoveClump(Clump clump)
    {
        if (clump.particleIds == null || clump.particleIds.Count == 0)
        {
            clumpMidpoints.Remove(clump.id);
            clumps?.Remove(clump);
            return;
        }

        StartCoroutine(HandleRemove(clump.particleIds));
        clumpMidpoints.Remove(clump.id);
        clumps?.Remove(clump);
    }

    public void AddHoneyCoating(HashSet<int> particleIds)
    {
        if (particleIds == null) return;
        foreach (int id in particleIds)
            if (idToIndex.TryGetValue(id, out int idx)) isHoneyCoated[idx] = true;
    }

    public void RemoveHoneyCoating(HashSet<int> particleIds)
    {
        if (particleIds == null) return;
        foreach (int id in particleIds)
        {
            if (idToIndex.TryGetValue(id, out int idx)) { isHoneyCoated[idx] = false; isStatic[idx] = false; }
        }
        OnRemoveHoneyCoating?.Invoke(particleIds, true);
        NotifyHoneyRemoved(particleIds);
    }

    private static void NotifyHoneyRemoved(HashSet<int> particleIds)
    {
        object manager = GetCollectionManagerInstance();
        if (manager == null) return;
        var m = manager.GetType().GetMethod("OnRemoveHoney", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
        if (m != null) m.Invoke(manager, new object[] { particleIds });
    }

    public Water AddWaterParticles(Unity.Mathematics.float2[] pos)
    {
        int type = GetNextUnusedFluidType();
        HashSet<int> ids = AddParticles(pos, type, ctx => isWater[ctx.Index] = true);
        Water water = TryInstantiateCollectionPrefab<Water>(transform);
        if (water != null) water.Init(this, ids, type, compute);
        return water;
    }

    public void ApplyImpulseToFish(int fishId, Unity.Mathematics.float2 impulse)
    {
        _lastJob.Complete();
        for (int i=0; i<ActiveCount; ++i)
            if (fishIds[i] == fishId) deltaVel[i] += impulse;
    }

    public Fish AddFish(UnityEngine.Vector2 pos, bool isBig = false)
    {
        int fishId = IdGenerator.Next();
        int type = GetNextUnusedFluidType();
        var spawnPositions = new Unity.Mathematics.float2[10];
        for (int i=0; i<spawnPositions.Length; ++i)
        {
            var p = UnityEngine.Random.insideUnitCircle;
            spawnPositions[i] = new Unity.Mathematics.float2(pos.x + p.x * 0.01f, pos.y + p.y * 0.01f);
        }
        HashSet<int> ids = AddParticles(spawnPositions, type, ctx => { fishIds[ctx.Index] = fishId; gravities[ctx.Index] = fishGravity; });
        Fish fish = UnityEngine.Object.Instantiate(fishPrefab, transform);
        if (fish == null) return null;
        fish.transform.position = new UnityEngine.Vector3(pos.x, pos.y, _nextFishZ);
        _nextFishZ += 0.001f;
        fish.Init(this, fishId, ids, type, null, fishMaterial, isBig);
        fishes.Add(fish);
        return fish;
    }

    public PowerUp AddPowerUp(Unity.Mathematics.float2 pos, int mergeIndex, bool isBig = false)
    {
        int puId = IdGenerator.Next();
        if (mergeIndex <= 1)
        {
            foreach (PowerUp other in powerUps)
            {
                if (other == null || other.id == puId || other.mergeIndex != mergeIndex || exploding.Contains(other.id)) continue;
                AddIgnorePair(puId, other.id);
            }
        }
        int fluidType = GetNextUnusedFluidType();
        var points = new Unity.Mathematics.float2[6]
        {
            pos,
            pos + new Unity.Mathematics.float2(0.067548744f, -0.07373716f),
            pos + new Unity.Mathematics.float2(-0.14087977f, 0.012364982f),
            pos + new Unity.Mathematics.float2(0.13745694f, 0.10538307f),
            pos + new Unity.Mathematics.float2(-0.034839515f, -0.19694215f),
            pos + new Unity.Mathematics.float2(0.1886718f, -0.12001231f)
        };
        HashSet<int> ids = AddParticles(points, fluidType, ctx => powerUpIds[ctx.Index] = puId);
        PowerUp powerUp = UnityEngine.Object.Instantiate(powerUpPrefab, transform);
        if (powerUp == null) return null;
        UnityEngine.Material material = null;
        if (powerUpMaterials != null && mergeIndex >= 0 && mergeIndex < powerUpMaterials.Length) material = powerUpMaterials[mergeIndex];
        powerUp.Init(this, puId, ids, fluidType, compute, mergeIndex, material, isBig);
        powerUps.Add(powerUp);
        powerUpById[puId] = powerUp;
        powerUp.StartCoroutine(powerUp.RotateBlob());
        return powerUp;
    }

    public Unity.Mathematics.float2 GetEvenlySpacedPosition(int index, float radius)
    {
        float r = UnityEngine.Mathf.Sqrt(index) * radius;
        float angle = index * goldenConstant * UnityEngine.Mathf.Deg2Rad;
        return new Unity.Mathematics.float2(UnityEngine.Mathf.Cos(angle) * r, UnityEngine.Mathf.Sin(angle) * r);
    }

    private void DetectPowerUpMerges()
    {
        for (int i=0; i<powerUps.Count; ++i)
        {
            PowerUp a = powerUps[i];
            if (a == null || exploding.Contains(a.id) || merging.ContainsKey(a.id) || a.mergeIndex > 1) continue;
            if (!powerUpMidpoints.TryGetValue(a.id, out var pa)) continue;
            for (int j=i+1; j<powerUps.Count; ++j)
            {
                PowerUp b = powerUps[j];
                if (b == null || exploding.Contains(b.id) || merging.ContainsKey(b.id) || b.mergeIndex != a.mergeIndex) continue;
                if (!powerUpMidpoints.TryGetValue(b.id, out var pb)) continue;
                if (Unity.Mathematics.math.lengthsq(pa - pb) > powerUpMergeDistance * powerUpMergeDistance) continue;
                if (ignorePairs.TryGetValue(PairKey(a.id,b.id), out _) || ignorePairs.TryGetValue(PairKey(b.id,a.id), out _)) continue;
                float now = UnityEngine.Time.time;
                merging[a.id] = new PowerUpMergeData { partner=b.id, startTime=now };
                merging[b.id] = new PowerUpMergeData { partner=a.id, startTime=now };
                break;
            }
        }
    }

    private void UpdateMergeDeltasAndFinish()
    {
        mergeDeltas.Clear();
        if (merging.Count == 0) return;
        var finish = new List<(int,int)>();
        float now = UnityEngine.Time.time;
        foreach (var pair in merging)
        {
            int id = pair.Key;
            int other = pair.Value.partner;
            if (id > other) continue;
            if (!powerUpMidpoints.TryGetValue(id, out var a) || !powerUpMidpoints.TryGetValue(other, out var b)) { finish.Add((id,other)); continue; }
            float t = mergeDuration > 0f ? UnityEngine.Mathf.Clamp01((now - pair.Value.startTime) / mergeDuration) : 1f;
            float eased = t * t * t;
            var deltaA = (b - a) * (0.5f * eased);
            var deltaB = (a - b) * (0.5f * eased);
            mergeDeltas[id] = deltaA;
            mergeDeltas[other] = deltaB;
            if (t >= 1f) finish.Add((id,other));
        }
        foreach (var p in finish) FinishMerge(p.Item1,p.Item2);
    }

    private void FinishMerge(int aId, int bId)
    {
        if (exploding.Contains(aId) || exploding.Contains(bId)) return;
        if (!powerUpById.TryGetValue(aId, out var a) || !powerUpById.TryGetValue(bId, out var b)) return;
        if (!powerUpMidpoints.TryGetValue(aId, out var pa) || !powerUpMidpoints.TryGetValue(bId, out var pb)) return;
        var pos = (pa + pb) * 0.5f;
        int layer = a.mergeIndex + 1;
        bool isBig = GetPowerUpIsBig(a) || GetPowerUpIsBig(b);
        RemovePowerUp(aId, 0f);
        RemovePowerUp(bId, 0f);
        StartCoroutine(SpawnMergedPowerUp(new UnityEngine.Vector2(pos.x,pos.y), layer, 0f, isBig));
        merging.Remove(aId); merging.Remove(bId);
    }

    private IEnumerator SpawnMergedPowerUp(UnityEngine.Vector2 pos, int layer, float delay, bool isBig)
    {
        if (delay > 0f) yield return new UnityEngine.WaitForSeconds(delay);
        AddPowerUp(new Unity.Mathematics.float2(pos.x,pos.y), layer, isBig);
    }

    public void RemovePowerUp(int puId, float delay = 0.3f)
    {
        _lastJob.Complete();
        if (!powerUpById.TryGetValue(puId, out PowerUp pu)) return;
        var ids = new HashSet<int>();
        for (int i=0; i<ActiveCount; ++i) if (powerUpIds[i] == puId) ids.Add(particleIds[i]);
        exploding.Remove(puId);
        powerUpById.Remove(puId);
        powerUps.Remove(pu);
        usedFluidTypes.Remove(pu.fluidType);
        powerUpMidpoints.Remove(puId);
        RemoveAllPairsWith(puId);
        if (pu.gameObject != null) UnityEngine.Object.Destroy(pu.gameObject);
        StartCoroutine(HandleRemove(ids, null, false, delay));
        merging.Remove(puId);
    }

    private void UpdatePowerUpMidpoints() { UpdateMidpoints(powerUps, p => p.id, p => p.particleIds, powerUpMidpoints); }
    private void UpdateCaterpillarMidpoints() { UpdateMidpoints(caterpillars, p => p.id, p => p.particleIds, caterpillarMidpoints); }
    private void UpdateBeeMidpoints() { UpdateMidpoints(bees, p => p.id, p => p.particleIds, beeMidpoints); }
    private void UpdateFishMidpoints() { UpdateMidpoints(fishes, p => p.id, p => p.particleIds, fishMidpoints); }
    private void UpdateSpongeMidpoints() { UpdateMidpoints(sponges, p => p.id, p => p.particleIds, spongeMidpoints); }

    private void UpdateClumpMidpoints()
    {
        clumpMidpoints.Clear();
        if (clumps == null) return;

        foreach (Clump clump in clumps)
        {
            if (clump.particleIds == null || clump.particleIds.Count == 0) continue;
            clumpMidpoints[clump.id] = GetAveragePositionFromIDs(clump.particleIds);
        }
    }

    private void UpdateOctopusHeadMidpoints()
    {
        octopusHeadMidpoints.Clear();
        foreach (var octopus in octopi)
        {
            if (octopus == null || octopus.particleIds == null) continue;
            var headIds = new HashSet<int>();
            foreach (int id in octopus.particleIds)
                if (idToIndex.TryGetValue(id, out int idx) && inOctopusHead[idx]) headIds.Add(id);
            if (headIds.Count > 0) octopusHeadMidpoints[octopus.id] = GetAveragePositionFromIDs(headIds);
        }
    }

    private void UpdateMidpoints<T>(IEnumerable<T> items, Func<T,int> idGetter, Func<T,HashSet<int>> idsGetter, Unity.Collections.NativeHashMap<int,Unity.Mathematics.float2> map) where T : class
    {
        map.Clear();
        foreach (var item in items)
        {
            if (item == null) continue;
            var ids = idsGetter(item);
            if (ids == null || ids.Count == 0) continue;
            map[idGetter(item)] = GetAveragePositionFromIDs(ids);
        }
    }

    private Unity.Mathematics.float2 GetAveragePositionFromIDs(HashSet<int> ids)
    {
        if (ids == null || ids.Count == 0) return Unity.Mathematics.float2.zero;
        Unity.Mathematics.float2 sum = Unity.Mathematics.float2.zero;
        int count = 0;
        foreach (int id in ids)
        {
            if (idToIndex.TryGetValue(id, out int idx)) { sum += positions[idx]; count++; }
        }
        return count == 0 ? Unity.Mathematics.float2.zero : sum / count;
    }

    public bool TryGetPowerUp(int id, out PowerUp pu) => powerUpById.TryGetValue(id, out pu);

    private void AddIgnorePair(int a, int b)
    {
        if (a < 0 || b < 0 || a == b || !ignorePairs.IsCreated) return;
        ignorePairs.TryAdd(PairKey(a,b), 1);
        ignorePairs.TryAdd(PairKey(b,a), 1);
    }

    private void RemoveAllPairsWith(int puId)
    {
        if (!ignorePairs.IsCreated) return;
        var keys = ignorePairs.GetKeyArray(Unity.Collections.Allocator.Temp);
        try
        {
            for (int i=0; i<keys.Length; ++i)
            {
                ulong key = keys[i];
                int a = unchecked((int)(uint)(key >> 32));
                int b = unchecked((int)(uint)key);
                if (a == puId || b == puId) ignorePairs.Remove(key);
            }
        }
        finally { keys.Dispose(); }
    }

    public void RadialDestroy(int puId)
    {
        if (exploding.Add(puId))
        {
            explosionQueue.Enqueue(puId);
            if (!isProcessing) StartCoroutine(ProcessExplosionQueue());
        }
    }

    private IEnumerator ProcessExplosionQueue()
    {
        if (isProcessing) yield break;
        isProcessing = true;
        while (explosionQueue.Count > 0)
        {
            int rootId = explosionQueue.Dequeue();
            yield return RadialDestroyRoutine(rootId);
            if (chainDelay > 0f) yield return new UnityEngine.WaitForSeconds(chainDelay);
        }
        isProcessing = false;
    }

    private IEnumerator RadialDestroyRoutine(int rootId)
    {
        if (!TryGetPowerUp(rootId, out PowerUp root) ||
            !powerUpMidpoints.TryGetValue(rootId, out var origin))
        {
            exploding.Remove(rootId);
            yield break;
        }

        OnDetonatePowerUp?.Invoke(root);
        RemoveAllPairsWith(rootId);

        // The original routine expands a radial destruction band over time.
        // Keep that temporal behavior instead of collapsing it to an instant removal.
        float startTime = Time.time;
        float charge = Mathf.Max(0f, chargeDuration);
        float duration = Mathf.Max(0.0001f, destroyDuration);

        var previousFrame = new HashSet<int>();
        var fading = new HashSet<int>();
        var triggeredPowerUps = new HashSet<int>();
        var dehoneyedParticles = new HashSet<int>();
        var dehoneyedBees = new HashSet<int>();

        // Charge / reveal phase. The original shader-facing effect uses a radial band.
        while (Time.time - startTime < charge)
        {
            float elapsed = Time.time - startTime;
            float radius = destroyRadius * Mathf.Clamp01(elapsed / Mathf.Max(charge, 0.0001f));
            float halfThickness = destroyBandThickness * 0.5f;
            var frame = CollectRadialBand(origin, radius, halfThickness, 0, id => true);
            foreach (int id in frame)
            {
                if (!previousFrame.Contains(id)) ClearHighlight(id);
                fading.Add(id);
            }
            previousFrame = frame;
            yield return null;
        }

        float detStart = Time.time;
        var processed = new HashSet<int>();
        while (Time.time - detStart < duration)
        {
            float curr = destroyRadius * Mathf.Clamp01((Time.time - detStart) / duration);
            var frame = CollectRadialBand(origin, curr, destroyBandThickness * 0.5f, 0, id =>
            {
                if (!idToIndex.TryGetValue(id, out int idx)) return false;
                return !isStatic[idx] && !isWater[idx];
            });

            foreach (int id in frame)
            {
                if (!processed.Add(id)) continue;
                ClearHighlight(id);
                if (idToIndex.TryGetValue(id, out int idx))
                {
                    int powerUpId = powerUpIds[idx];
                    if (powerUpId >= 0 && powerUpId != rootId) triggeredPowerUps.Add(powerUpId);
                }
            }

            // Bee/snow interactions are part of the original splash path.
            foreach (int id in frame)
            {
                if (!idToIndex.TryGetValue(id, out int idx)) continue;
                if (beeIds[idx] >= 0) OnHitBeeParticle(idx, beeIds[idx], ref dehoneyedParticles, ref dehoneyedBees);
            }

            if (frame.Count > 0) HandleSplashDestroy(frame);
            fading.UnionWith(frame);
            yield return null;
        }

        var affected = CollectRadialBand(origin, destroyRadius, destroyBandThickness * 0.5f, 0, id =>
        {
            if (!idToIndex.TryGetValue(id, out int idx)) return false;
            return !isStatic[idx] && !isWater[idx];
        });
        foreach (int id in processed) affected.Add(id);

        if (affected.Count > 0)
        {
            HandleSplashDestroy(affected);
            OnStartRemoveParticles?.Invoke(affected, true);
            foreach (int id in affected)
                if (idToIndex.TryGetValue(id, out int idx)) scales[idx] = 0f;
            RemoveParticles(affected);
        }

        if (dehoneyedParticles.Count > 0) RemoveHoneyCoating(dehoneyedParticles);

        RemovePowerUp(rootId, 0f);
        foreach (int chainedId in triggeredPowerUps)
        {
            if (chainedId == rootId || !powerUpById.ContainsKey(chainedId)) continue;
            if (exploding.Add(chainedId)) explosionQueue.Enqueue(chainedId);
        }

        exploding.Remove(rootId);
        yield return null;
    }

    private HashSet<int> CollectRadialBand(Unity.Mathematics.float2 origin, float radius, float halfThickness, int bandType, Func<int, bool> includeId)
    {
        var result = new HashSet<int>();
        float currentRadius = Mathf.Max(0f, radius);
        float thickness = Mathf.Max(0f, halfThickness);
        float innerRadius = Mathf.Max(0f, currentRadius - thickness);
        float innerSq = innerRadius * innerRadius;
        float outerSq = currentRadius * currentRadius;

        for (int i = 0; i < ActiveCount; ++i)
        {
            int id = particleIds[i];
            if (!includeId(id)) continue;
            Unity.Mathematics.float2 delta = positions[i] - origin;
            float distSq = Unity.Mathematics.math.lengthsq(delta);
            if (distSq > outerSq || distSq <= innerSq) continue;

            if (bandType == 1 &&
                (Mathf.Abs(delta.y) >= thickness || Mathf.Abs(delta.x) >= thickness))
                continue;

            result.Add(id);
        }
        return result;
    }

    private void ClearHighlight(int pid)
    {
        if (idToIndex.TryGetValue(pid, out int idx)) emissionColors[idx] = new Unity.Mathematics.float4(0f, 0f, 0f, 0f);
    }

    private void HandleSplashDestroy(HashSet<int> ids)
    {
        if (ids == null || ids.Count == 0) return;
        foreach (int id in ids)
        {
            if (!idToIndex.TryGetValue(id, out int idx)) continue;
            splashImpulse[idx] = Math.Max(splashImpulse[idx], splashDownStrength);
        }
    }

    private HashSet<int> CollectNearbyParticles(HashSet<int> sources, float r, Func<int,bool> includeId)
    {
        var result = new HashSet<int>();
        float rSq = r * r;
        if (sources != null)
        {
            foreach (int id in sources)
                if (idToIndex.TryGetValue(id, out int idx)) result.Add(particleIds[idx]);
        }

        // When no explicit source ids are supplied, use the active power-up / root context by position is not recoverable.
        // For the common radial path, use every non-water particle whose position lies within r of each source.
        if (sources == null || sources.Count == 0) return result;
        var sourcePositions = new List<Unity.Mathematics.float2>();
        foreach (int id in sources) if (idToIndex.TryGetValue(id, out int idx)) sourcePositions.Add(positions[idx]);
        for (int i=0; i<ActiveCount; ++i)
        {
            int id = particleIds[i];
            if (!includeId(id)) continue;
            foreach (var p in sourcePositions)
            {
                if (Unity.Mathematics.math.lengthsq(positions[i] - p) <= rSq) { result.Add(id); break; }
            }
        }
        return result;
    }

    public void OnHitBeeParticle(int idx, int beeId, ref HashSet<int> dehoneyedParticleIds, ref HashSet<int> dehoneyedBeeIds)
    {
        Bee bee = null;
        foreach (var b in bees) if (b != null && b.id == beeId) { bee = b; break; }
        if (bee == null) return;
        if (idx >= 0 && idx < ActiveCount && isHoneyCoated[idx])
        {
            if (bee.solverIds != null)
                foreach (int id in bee.solverIds) dehoneyedParticleIds.Add(id);
            dehoneyedBeeIds.Add(beeId);
            return;
        }
        if (!dehoneyedBeeIds.Contains(beeId))
        {
            NotifyBeeCollected(bee.position);
            RemoveBee(bee);
        }
    }

    public void StartRejectFlash(HashSet<int> ids)
    {
        if (rejectFlash != null) StopCoroutine(rejectFlash);
        rejectFlash = HandleRejectFlash(ids);
        StartCoroutine(rejectFlash);
    }

    private IEnumerator HandleRejectFlash(HashSet<int> ids)
    {
        var state = new HashSet<int>(ids ?? new HashSet<int>());
        float start = UnityEngine.Time.time;
        const float duration = 0.5f;
        while (UnityEngine.Time.time < start + duration)
        {
            float t = UnityEngine.Mathf.Clamp01((UnityEngine.Time.time - start) / duration);
            float alpha = 1f - EasingFunction.EaseOutCubic(t);
            SetEmissionValues(1f, alpha, state);
            yield return null;
        }
        SetEmissionValues(0f, 0f, state);
        rejectFlash = null;
    }

    private void SetEmissionValues(float g, float a, HashSet<int> ids)
    {
        if (ids == null) return;
        foreach (int id in ids)
            if (idToIndex.TryGetValue(id, out int idx)) emissionColors[idx] = new Unity.Mathematics.float4(0f,g,0f,a);
    }

    public FluidSolver()
    {
        usedFluidTypes = new HashSet<int>();
        powerUps = new List<PowerUp>();
        powerUpById = new Dictionary<int,PowerUp>();
        explosionQueue = new Queue<int>();
        octopi = new List<Octopus>();
        caterpillars = new List<Caterpillar>();
        bees = new List<Bee>();
        sponges = new List<Sponge>();
        _pendingRemovalIds = new HashSet<int>();
        merging = new Dictionary<int,PowerUpMergeData>();
        exploding = new HashSet<int>();
        honeys = new List<Honey>();
        clumps = new List<Clump>();
        fishes = new List<Fish>();
        powerUpMaterials = new UnityEngine.Material[3];

        viscosityStrength = 0f;
        buoyancyStrength = 4f;
        waterReactionMultiplier = 0.12f;
        splashDownStrength = 8f;
        powerUpThreshold = 0;
        bigPowerUpThreshold = 0;
        destroyDuration = 0.2f;
        chargeDuration = 0.5f;
        chainDelay = 0.5f;
        spongeCohesionRadius = 0.15f;
        spongeSpringStrength = 40f;
        octopusHeadParticleCount = 4;
        powerUpMergeDistance = 0.6f;
        mergeDuration = 0.5f;
        splashDestroyRadius = 0.4f;
        defaultGravity = Unity.Mathematics.float2.zero;
    }
}
