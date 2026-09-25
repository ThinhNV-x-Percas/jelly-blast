using System;
using System.Collections;
using System.Collections.Generic;
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

    public Unity.Collections.NativeHashMap<int, int> idToIndex;
    private Unity.Collections.NativeMultiHashMap<int, int> cellMap;
    private int capacity;
    internal Unity.Jobs.JobHandle _lastJob;

    public PowerUp powerUpPrefab;
    public UnityEngine.Material[] powerUpMaterials;
    public List<PowerUp> powerUps;
    private readonly Dictionary<int, PowerUp> powerUpById;

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
    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> caterpillarMidpoints;
    public List<Caterpillar> caterpillars;
    public Unity.Collections.NativeArray<int> beeIds;
    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> beeMidpoints;
    public List<Bee> bees;

    [UnityEngine.Header("Sponges")]
    public List<Sponge> sponges;
    public Unity.Collections.NativeArray<int> spongeIds;
    public float spongeCohesionRadius;
    public float spongeSpringStrength;
    public Unity.Collections.NativeArray<bool> isWater;

    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> powerUpMidpoints;
    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> fishMidpoints;
    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> clumpMidpoints;
    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> spongeMidpoints;
    public Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> octopusHeadMidpoints;

    private Unity.Collections.NativeArray<int> octUFParent;
    private Unity.Collections.NativeArray<byte> octComponentHasHead;
    private readonly HashSet<int> _pendingRemovalIds;
    private Unity.Collections.NativeHashMap<ulong, byte> ignorePairs;

    [UnityEngine.Header("Power-up Merging")]
    public float powerUpMergeDistance;
    public float mergeDuration;
    private readonly Dictionary<int, PowerUpMergeData> merging;
    private Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> mergeDeltas;
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

    private static GameManager Game => global::Singleton<GameManager>.Instance;

    private static FluidCompute SharedCompute
    {
        get
        {
            GameManager game = Game;
            return game != null ? game.compute : null;
        }
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

        idToIndex = new Unity.Collections.NativeHashMap<int, int>(maxParticles, Unity.Collections.Allocator.Persistent);
        capacity = NextPowerOfTwo(maxParticles);
        cellMap = new Unity.Collections.NativeMultiHashMap<int, int>(capacity, Unity.Collections.Allocator.Persistent);
        powerUpMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        fishMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        caterpillarMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        beeMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        clumpMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        spongeMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        octopusHeadMidpoints = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(maxParticles, Unity.Collections.Allocator.Persistent);
        ignorePairs = new Unity.Collections.NativeHashMap<ulong, byte>(128, Unity.Collections.Allocator.Persistent);
        mergeDeltas = new Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2>(128, Unity.Collections.Allocator.Persistent);
        octUFParent = new Unity.Collections.NativeArray<int>(maxParticles, Unity.Collections.Allocator.Persistent, Unity.Collections.NativeArrayOptions.ClearMemory);
        octComponentHasHead = new Unity.Collections.NativeArray<byte>(maxParticles, Unity.Collections.Allocator.Persistent);

        ActiveCount = 0;
        if (colorFluidTypes > 0)
            for (int i = 0; i < colorFluidTypes; ++i) usedFluidTypes.Add(i);
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
        Dispose(ref isWater); Dispose(ref isHoneyCoated); Dispose(ref waterDensities); Dispose(ref splashImpulse); Dispose(ref isStatic);
        Dispose(ref viscosityStrengths); Dispose(ref nearPressureMultipliers); Dispose(ref octUFParent); Dispose(ref octComponentHasHead);
        Dispose(ref idToIndex); Dispose(ref cellMap); Dispose(ref powerUpMidpoints); Dispose(ref fishMidpoints);
        Dispose(ref caterpillarMidpoints); Dispose(ref beeMidpoints); Dispose(ref clumpMidpoints); Dispose(ref spongeMidpoints);
        Dispose(ref octopusHeadMidpoints); Dispose(ref ignorePairs); Dispose(ref mergeDeltas);
    }

    private static void Dispose<T>(ref Unity.Collections.NativeArray<T> value) where T : struct
    {
        if (value.IsCreated) value.Dispose();
    }

    private static void Dispose<TKey, TValue>(ref Unity.Collections.NativeHashMap<TKey, TValue> value)
        where TKey : struct, IEquatable<TKey>
        where TValue : struct
    {
        if (value.IsCreated) value.Dispose();
    }

    private static void Dispose<TKey, TValue>(ref Unity.Collections.NativeMultiHashMap<TKey, TValue> value)
        where TKey : struct, IEquatable<TKey>
        where TValue : struct
    {
        if (value.IsCreated) value.Dispose();
    }

    public void Step(float dt)
    {
        // Finish the previous step's job chain before any main-thread reads/writes of the
        // native containers below (midpoint updates, positions/positionsPrev copy, cellMap.Clear).
        // Without this, PredictJob/BlobCohesionJob from the previous step are still running.
        _lastJob.Complete();
        UpdateFishMidpoints();
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
        if (merging.Count > 0)
        {
            Unity.Jobs.IJobParallelForExtensions.Schedule(new PowerUpMergeTranslateJob
            {
                positions = positions,
                velocities = velocities,
                powerUpIds = powerUpIds,
                mergeDeltas = mergeDeltas,
                dt = dt
            }, ActiveCount, 64).Complete();
        }
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
            blobIds = caterpillarIds,
            blobMidpoints = caterpillarMidpoints,
            cohesionRadius = fishCohesionRadius,
            springStrength = fishSpringStrength,
            dt = dt
        }, ActiveCount, 64, dependsOn13);
        Unity.Jobs.JobHandle dependsOn15 = Unity.Jobs.IJobParallelForExtensions.Schedule(new BlobCohesionJob
        {
            positions = positions,
            deltaVel = deltaVel,
            blobIds = beeIds,
            blobMidpoints = beeMidpoints,
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
        // Both OctopusHeadCohesionJob (jobHandle) and OctopusBodyCohesionJob write deltaVel,
        // so the body job must wait for the head job as well as the region-map chain.
        }, ActiveCount, 64, Unity.Jobs.JobHandle.CombineDependencies(dependsOn18, jobHandle));
        Unity.Jobs.JobHandle dependsOn19 = jobHandle3;
        // Pressure/Viscosity/Buoyancy/SplashDown/Cohesion all accumulate into deltaVel;
        // without this the whole force pipeline is discarded and particles never repel.
        Unity.Jobs.JobHandle dependsOn20 = Unity.Jobs.IJobParallelForExtensions.Schedule(new ApplyDeltaJob
        {
            velocities = velocities,
            deltaVel = deltaVel,
            isStatic = isStatic
        }, ActiveCount, 64, dependsOn19);
        Unity.Jobs.JobHandle jobHandle4 = Unity.Jobs.IJobParallelForExtensions.Schedule(new IntegrateJob
        {
            positions = positions,
            velocities = velocities,
            isStatic = isStatic,
            dt = dt
        }, ActiveCount, 64, dependsOn20);
        _lastJob.Complete();
        _lastJob = jobHandle4;
        // Complete this step's chain before onStep callbacks and any other main-thread
        // access to the native containers (input queries, coupler jobs, rendering reads).
        _lastJob.Complete();
        global::System.Action onStep = OnStep;
        if (onStep != null)
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
        for (int i = 0; i < count; ++i)
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
        float bestSq = float.MaxValue;
        int best = -1;
        var target = new Unity.Mathematics.float2(worldPos.x, worldPos.y);
        for (int i = 0; i < ActiveCount; ++i)
        {
            if (isWater[i]) continue;
            var d = positions[i] - target;
            float dsq = Unity.Mathematics.math.lengthsq(d);
            if (dsq < maxSq && dsq < bestSq) { bestSq = dsq; best = i; }
        }
        return best;
    }

    /// <summary>
    /// Flood-fills the contiguous blob that contains <paramref name="seedIndex"/> and returns the
    /// PARTICLE IDs of that blob (callers such as GameManager feed the result straight into
    /// <see cref="UserRemoveRegion"/> / <see cref="StartRejectFlash"/>, which work in id space).
    /// Matches the original: neighbours must share the seed's particle type and honey-coating state,
    /// and connectivity is evaluated on a uniform grid of cell size particleRadius * 2.
    /// </summary>
    public HashSet<int> FindContiguousRegionIndices(int seedIndex)
    {
        var result = new HashSet<int>();
        if (seedIndex < 0 || seedIndex >= ActiveCount) return result;

        int seedType = particleTypes[seedIndex];
        bool seedHoney = isHoneyCoated[seedIndex];
        float cell = UnityEngine.Mathf.Max(0.0001f, particleRadius * 2f);
        float inv = 1f / cell;
        float thresholdSq = cell * cell;

        var grid = new Dictionary<UnityEngine.Vector2Int, List<int>>(ActiveCount);
        for (int i = 0; i < ActiveCount; ++i)
        {
            if (particleTypes[i] != seedType || isHoneyCoated[i] != seedHoney) continue;
            var key = CellKey(positions[i], inv);
            if (!grid.TryGetValue(key, out List<int> bucket))
            {
                bucket = new List<int>();
                grid[key] = bucket;
            }
            bucket.Add(i);
        }

        var visited = new HashSet<int> { seedIndex };
        var queue = new Queue<int>();
        queue.Enqueue(seedIndex);
        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            result.Add(particleIds[current]);
            Unity.Mathematics.float2 p = positions[current];
            UnityEngine.Vector2Int c = CellKey(p, inv);
            for (int ox = -1; ox <= 1; ++ox)
            {
                for (int oy = -1; oy <= 1; ++oy)
                {
                    if (!grid.TryGetValue(new UnityEngine.Vector2Int(c.x + ox, c.y + oy), out List<int> bucket)) continue;
                    for (int k = 0; k < bucket.Count; ++k)
                    {
                        int j = bucket[k];
                        if (visited.Contains(j)) continue;
                        if (Unity.Mathematics.math.lengthsq(positions[j] - p) > thresholdSq) continue;
                        visited.Add(j);
                        queue.Enqueue(j);
                    }
                }
            }
        }
        return result;
    }

    private static UnityEngine.Vector2Int CellKey(Unity.Mathematics.float2 p, float inv)
    {
        return new UnityEngine.Vector2Int(
            (int)UnityEngine.Mathf.Floor(p.x * inv),
            (int)UnityEngine.Mathf.Floor(p.y * inv));
    }

    /// <summary>Splits a set of particle ids into its contiguous blobs (id space in, id space out).</summary>
    public List<HashSet<int>> FindContiguousRegions(HashSet<int> ids)
    {
        var regions = new List<HashSet<int>>();
        if (ids == null || ids.Count == 0) return regions;
        var remaining = new HashSet<int>(ids);
        while (remaining.Count > 0)
        {
            int id = 0;
            foreach (int first in remaining) { id = first; break; }
            if (!idToIndex.TryGetValue(id, out int seedIndex))
            {
                remaining.Remove(id);
                continue;
            }
            HashSet<int> blobIds = FindContiguousRegionIndices(seedIndex);
            var regionIds = new HashSet<int>();
            foreach (int rid in blobIds)
                if (remaining.Contains(rid)) regionIds.Add(rid);
            if (regionIds.Count == 0) regionIds.Add(id);
            regions.Add(regionIds);
            foreach (int rid in regionIds) remaining.Remove(rid);
        }
        return regions;
    }

    public void UserRemoveRegion(HashSet<int> ids, int touchId, UnityEngine.Vector2 wPos, float delay = 0.3f)
    {
        if (ids == null || ids.Count == 0) return;

        // `fresh` is the subset that is not already queued for removal; the power-up decision is
        // taken on it, while the actual removal still runs over the full incoming set.
        var fresh = new HashSet<int>();
        foreach (int id in ids)
            if (_pendingRemovalIds.Add(id)) fresh.Add(id);

        bool createPowerup = fresh.Count >= (isClumped ? 16 : powerUpThreshold);
        OnRemoveRegionStart?.Invoke(createPowerup, wPos);
        if (createPowerup) OnCreatePowerup?.Invoke(fresh, wPos);

        // touchId is the seed *index* returned by FindClosestParticle; the power-up spawns there.
        UnityEngine.Vector2 touchPos = (touchId >= 0 && touchId < ActiveCount)
            ? new UnityEngine.Vector2(positions[touchId].x, positions[touchId].y)
            : wPos;

        HandleSplashDestroy(ids);

        Action<HashSet<int>> onRemove = removed =>
        {
            if (createPowerup)
            {
                bool isBig = fresh.Count > bigPowerUpThreshold;
                AddPowerUp(new Unity.Mathematics.float2(touchPos.x, touchPos.y), 0, isBig);
            }
            OnRemoveRegionComplete?.Invoke(removed, touchId);
        };
        // NOTE: the original ignores the `delay` argument here and always uses HandleRemove's 0.2s.
        StartCoroutine(HandleRemove(ids, onRemove, !createPowerup));
    }

    private IEnumerator HandleRemove(HashSet<int> ids, Action<HashSet<int>> onRemove = null, bool explode = true, float delay = 0.2f)
    {
        if (ids == null || ids.Count == 0) yield break;
        _lastJob.Complete();
        foreach (int id in ids)
            if (idToIndex.TryGetValue(id, out int index)) scales[index] = 0f;
        if (OnStartRemoveParticles != null)
        {
            foreach (Delegate handler in OnStartRemoveParticles.GetInvocationList())
            {
                try { ((Action<HashSet<int>, bool>)handler)(ids, explode); }
                catch (Exception e) { UnityEngine.Debug.LogError(e); }
            }
        }
        yield return new UnityEngine.WaitForSeconds(delay);
        RemoveParticles(ids, onRemove);
        foreach (int id in ids) _pendingRemovalIds.Remove(id);
    }

    public void RemoveParticles(HashSet<int> ids, Action<HashSet<int>> onRemove = null)
    {
        if (ids == null || ids.Count == 0) return;
        _lastJob.Complete();

        foreach (int id in ids) idToIndex.Remove(id);

        int writeIndex = 0;
        for (int readIndex = 0; readIndex < ActiveCount; ++readIndex)
        {
            if (ids.Contains(particleIds[readIndex])) continue;
            if (readIndex != writeIndex)
            {
                positions[writeIndex] = positions[readIndex];
                positionsPrev[writeIndex] = positionsPrev[readIndex];
                predicted[writeIndex] = predicted[readIndex];
                velocities[writeIndex] = velocities[readIndex];
                densities[writeIndex] = densities[readIndex];
                deltaVel[writeIndex] = deltaVel[readIndex];
                // gravities / waterDensities / splashImpulse / isSimulated were missing from the
                // decompiled body; they are per-particle state so they are compacted too.
                gravities[writeIndex] = gravities[readIndex];
                particleTypes[writeIndex] = particleTypes[readIndex];
                emissionColors[writeIndex] = emissionColors[readIndex];
                scales[writeIndex] = scales[readIndex];
                particleIds[writeIndex] = particleIds[readIndex];
                powerUpIds[writeIndex] = powerUpIds[readIndex];
                caterpillarIds[writeIndex] = caterpillarIds[readIndex];
                beeIds[writeIndex] = beeIds[readIndex];
                fishIds[writeIndex] = fishIds[readIndex];
                octopusIds[writeIndex] = octopusIds[readIndex];
                inOctopusHead[writeIndex] = inOctopusHead[readIndex];
                isHoneyCoated[writeIndex] = isHoneyCoated[readIndex];
                spongeIds[writeIndex] = spongeIds[readIndex];
                isWater[writeIndex] = isWater[readIndex];
                isSimulated[writeIndex] = isSimulated[readIndex];
                waterDensities[writeIndex] = waterDensities[readIndex];
                splashImpulse[writeIndex] = splashImpulse[readIndex];
                viscosityStrengths[writeIndex] = viscosityStrengths[readIndex];
                nearPressureMultipliers[writeIndex] = nearPressureMultipliers[readIndex];
                clumpIds[writeIndex] = clumpIds[readIndex];
                isStatic[writeIndex] = isStatic[readIndex];
            }
            idToIndex[particleIds[writeIndex]] = writeIndex;
            writeIndex++;
        }
        ActiveCount = writeIndex;
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
        HashSet<int> ids = AddParticles(positionsToAdd, mudFluidType);
        GameManager game = Game;
        if (game == null || game.mudPrefab == null) return null;
        mudInstance = UnityEngine.Object.Instantiate(game.mudPrefab, transform);
        mudInstance.Init(this, ids, mudFluidType, game.compute);
        return mudInstance;
    }

    public Snow AddSnow(Unity.Mathematics.float2[] positionsToAdd)
    {
        if (snowInstance != null) { snowInstance.AddParticles(positionsToAdd); return snowInstance; }
        HashSet<int> ids = AddParticles(positionsToAdd, snowFluidType);
        GameManager game = Game;
        if (game == null || game.snowPrefab == null) return null;
        snowInstance = UnityEngine.Object.Instantiate(game.snowPrefab, transform);
        snowInstance.Init(this, ids, snowFluidType, game.compute);
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
            if (ctx.Local < octopusHeadParticleCount) { inOctopusHead[ctx.Index] = true; headIds.Add(ctx.Id); }
        });
        GameManager game = Game;
        if (game == null || game.octopusPrefab == null) return null;
        Octopus octopus = UnityEngine.Object.Instantiate(game.octopusPrefab, transform);
        octopus.Init(this, ids, fluidType, game.compute, octId, headIds, splitIndex);
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
        for (int i = 0; i < ActiveCount; ++i) regionHasHead[i] = false;
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
        GameManager game = Game;
        if (game == null || game.caterpillarPrefab == null) return null;
        Caterpillar c = UnityEngine.Object.Instantiate(game.caterpillarPrefab, transform);
        c.Init(this, ids, type, game.compute, id);
        caterpillars.Add(c);
        return c;
    }

    public Bee AddBee(Unity.Mathematics.float2[] pos)
    {
        int type = GetNextUnusedFluidType();
        int id = IdGenerator.Next();
        HashSet<int> ids = AddParticles(pos, type, ctx =>
        {
            isHoneyCoated[ctx.Index] = true;
            beeIds[ctx.Index] = id;
            // The original also registers the bee's particles with the shared honey renderer.
            GameManager gm = Game;
            if (gm != null && gm.honeyTest != null) gm.honeyTest.AddSolverParticle(ctx);
        });
        GameManager game = Game;
        if (game == null || game.beePrefab == null) return null;
        Bee b = UnityEngine.Object.Instantiate(game.beePrefab, transform);
        b.Init(this, ids, type, game.compute, id);
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
        GameManager game = Game;
        if (game == null || game.spongePrefab == null) return null;
        Sponge s = UnityEngine.Object.Instantiate(game.spongePrefab, transform);
        s.Init(this, ids, type, game.compute, id);
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
        HashSet<int> particleIdsAdded = AddParticles(pos, type, ctx => clumpIds[ctx.Index] = clumpId);

        Clump clump = new Clump
        {
            id = clumpId,
            particleIds = particleIdsAdded
        };

        if (clumps == null) clumps = new List<Clump>();
        clumps.Add(clump);
        return clump;
    }

    public void RemoveClump(Clump clump)
    {
        if (clump.particleIds != null && clump.particleIds.Count > 0)
            StartCoroutine(HandleRemove(clump.particleIds));
        clumpMidpoints.Remove(clump.id);
        clumps?.Remove(clump);
    }

    public void AddHoneyCoating(HashSet<int> particleIdsToCoat)
    {
        if (particleIdsToCoat == null) return;
        foreach (int id in particleIdsToCoat)
            if (idToIndex.TryGetValue(id, out int idx)) isHoneyCoated[idx] = true;
    }

    public void RemoveHoneyCoating(HashSet<int> particleIdsToUncoat)
    {
        if (particleIdsToUncoat == null) return;
        foreach (int id in particleIdsToUncoat)
        {
            if (idToIndex.TryGetValue(id, out int idx)) { isHoneyCoated[idx] = false; isStatic[idx] = false; }
        }
        CollectionManager collectionManager = global::Singleton<CollectionManager>.Instance;
        if (collectionManager != null)
        {
            collectionManager.OnRemoveHoney(particleIdsToUncoat);
            OnRemoveHoneyCoating?.Invoke(particleIdsToUncoat, true);
        }
    }

    public Water AddWaterParticles(Unity.Mathematics.float2[] pos)
    {
        int type = GetNextUnusedFluidType();
        HashSet<int> ids = AddParticles(pos, type, ctx => isWater[ctx.Index] = true);
        GameManager game = Game;
        if (game == null || game.waterPrefab == null) return null;
        Water water = UnityEngine.Object.Instantiate(game.waterPrefab, transform);
        water.Init(this, ids, type, game.compute);
        game.waters?.Add(water);
        return water;
    }

    public void ApplyImpulseToFish(int fishId, Unity.Mathematics.float2 impulse)
    {
        _lastJob.Complete();
        for (int i = 0; i < ActiveCount; ++i)
            if (fishIds[i] == fishId) deltaVel[i] += impulse;
    }

    public Fish AddFish(UnityEngine.Vector2 pos, bool isBig = false)
    {
        int fishId = IdGenerator.Next();
        int type = GetNextUnusedFluidType();
        var spawnPositions = new Unity.Mathematics.float2[10];
        for (int i = 0; i < spawnPositions.Length; ++i)
        {
            var p = UnityEngine.Random.insideUnitCircle;
            spawnPositions[i] = new Unity.Mathematics.float2(pos.x + p.x * 0.01f, pos.y + p.y * 0.01f);
        }
        HashSet<int> ids = AddParticles(spawnPositions, type, ctx =>
        {
            fishIds[ctx.Index] = fishId;
            gravities[ctx.Index] = fishGravity;
        });
        if (fishPrefab == null) return null;
        Fish fish = UnityEngine.Object.Instantiate(fishPrefab, transform);
        fish.transform.position = new UnityEngine.Vector3(pos.x, pos.y, _nextFishZ);
        _nextFishZ += 0.001f;
        fish.Init(this, fishId, ids, type, null, fishMaterial, isBig);
        fishes.Add(fish);
        return fish;
    }

    public PowerUp AddPowerUp(Unity.Mathematics.float2 pos, int mergeIndex, bool isBig = false)
    {
        if (powerUpMaterials == null || mergeIndex < 0 || powerUpMaterials.Length <= mergeIndex) return null;

        int puId = IdGenerator.Next();

        // A freshly spawned power-up must not immediately re-merge with the power-ups that are
        // already on the board at the same tier.
        if (mergeIndex <= 1 && powerUps != null)
        {
            foreach (PowerUp other in powerUps)
            {
                if (other == null || other.id == puId || other.mergeIndex != mergeIndex) continue;
                if (exploding.Contains(other.id)) continue;
                AddIgnorePair(puId, other.id);
            }
        }

        var points = new Unity.Mathematics.float2[6];
        points[0] = pos;
        for (int i = 1; i < points.Length; ++i)
            points[i] = pos + GetEvenlySpacedPosition(i, 0.1f);

        int fluidType = GetNextUnusedFluidType();
        HashSet<int> ids = AddParticles(points, fluidType, ctx => powerUpIds[ctx.Index] = puId);
        if (powerUpPrefab == null) return null;
        PowerUp powerUp = UnityEngine.Object.Instantiate(powerUpPrefab, transform);
        powerUp.Init(this, puId, ids, fluidType, SharedCompute, mergeIndex, powerUpMaterials[mergeIndex], isBig);
        powerUps.Add(powerUp);
        powerUpById[puId] = powerUp;
        powerUp.StartCoroutine(powerUp.RotateBlob());

        AudioManager audioManager = global::Singleton<AudioManager>.Instance;
        if (audioManager != null)
        {
            audioManager.PlayClip("charge up", new AudioClipSettings
            {
                pitch = 1.5f,
                pitchVariance = 0.2f
            });
        }
        return powerUp;
    }

    public Unity.Mathematics.float2 GetEvenlySpacedPosition(int index, float radius)
    {
        float r = UnityEngine.Mathf.Sqrt(index) * radius;
        float angle = index * goldenConstant * UnityEngine.Mathf.Deg2Rad;
        return new Unity.Mathematics.float2(r * UnityEngine.Mathf.Cos(angle), r * UnityEngine.Mathf.Sin(angle));
    }

    private void DetectPowerUpMerges()
    {
        if (powerUps == null) return;
        float now = UnityEngine.Time.time;
        for (int i = 0; i < powerUps.Count; ++i)
        {
            PowerUp a = powerUps[i];
            if (a == null || exploding.Contains(a.id) || merging.ContainsKey(a.id) || a.mergeIndex > 1) continue;
            for (int j = i + 1; j < powerUps.Count; ++j)
            {
                PowerUp b = powerUps[j];
                if (b == null || exploding.Contains(b.id) || merging.ContainsKey(b.id)) continue;
                if (a.mergeIndex != b.mergeIndex) continue;

                float dx = a.position.x - b.position.x;
                float dy = a.position.y - b.position.y;
                float dist = UnityEngine.Mathf.Sqrt(dx * dx + dy * dy);
                if (dist > powerUpMergeDistance) continue;

                merging[a.id] = new PowerUpMergeData { partner = b.id, startTime = now };
                merging[b.id] = new PowerUpMergeData { partner = a.id, startTime = now };
                // While merging, the pair must attract rather than be pushed apart.
                RemoveAllPairsWith(a.id);
                RemoveAllPairsWith(b.id);
                AddIgnorePair(a.id, b.id);
                break;
            }
        }
    }

    private void UpdateMergeDeltasAndFinish()
    {
        mergeDeltas.Clear();
        if (merging == null || merging.Count == 0) return;

        float now = UnityEngine.Time.time;
        var finish = new List<(int, int)>();
        foreach (var pair in merging)
        {
            int aId = pair.Key;
            int bId = pair.Value.partner;
            if (!powerUpById.TryGetValue(aId, out PowerUp a) || a == null) continue;
            if (!powerUpById.TryGetValue(bId, out PowerUp b) || b == null) continue;
            if (!powerUpMidpoints.TryGetValue(aId, out Unity.Mathematics.float2 pa)) continue;
            if (!powerUpMidpoints.TryGetValue(bId, out Unity.Mathematics.float2 pb)) continue;

            float t = mergeDuration > 0f
                ? UnityEngine.Mathf.Clamp01((now - pair.Value.startTime) / mergeDuration)
                : 1f;
            float eased = t * t * t;
            Unity.Mathematics.float2 mid = (pa + pb) * 0.5f;
            mergeDeltas[aId] = (mid - pa) * eased;
            mergeDeltas[bId] = (mid - pb) * eased;
            if (t >= 1f && aId < bId) finish.Add((aId, bId));
        }
        foreach (var p in finish) FinishMerge(p.Item1, p.Item2);
    }

    private void FinishMerge(int aId, int bId)
    {
        if (exploding.Contains(aId) || exploding.Contains(bId)) return;
        if (!powerUpById.TryGetValue(aId, out PowerUp a) || a == null) return;
        if (!powerUpById.TryGetValue(bId, out PowerUp b) || b == null) return;

        int layer = a.mergeIndex + 1;
        // Reaching the top tier always produces a big power-up; otherwise bigness is inherited.
        bool isBig = layer == 2 || a.isBig || b.isBig;
        var pos = new UnityEngine.Vector2(
            (a.position.x + b.position.x) * 0.5f,
            (a.position.y + b.position.y) * 0.5f);

        RemovePowerUp(aId, 0f);
        RemovePowerUp(bId, 0f);
        StartCoroutine(SpawnMergedPowerUp(pos, layer, 0f, isBig));
        merging.Remove(aId);
        merging.Remove(bId);
    }

    private IEnumerator SpawnMergedPowerUp(UnityEngine.Vector2 pos, int layer, float delay, bool isBig)
    {
        yield return new UnityEngine.WaitForSeconds(delay);
        AddPowerUp(new Unity.Mathematics.float2(pos.x, pos.y), layer, isBig);
    }

    public void RemovePowerUp(int puId, float delay = 0.3f)
    {
        _lastJob.Complete();

        var ids = new HashSet<int>();
        for (int i = 0; i < ActiveCount; ++i)
            if (powerUpIds[i] == puId) ids.Add(particleIds[i]);

        PowerUp pu = null;
        if (powerUpById.TryGetValue(puId, out pu))
        {
            powerUpById.Remove(puId);
            powerUps.Remove(pu);
            if (pu != null && pu.gameObject != null) UnityEngine.Object.Destroy(pu.gameObject);
        }

        Action<HashSet<int>> onRemove = removed =>
        {
            if (pu != null) usedFluidTypes.Remove(pu.fluidType);
            powerUpMidpoints.Remove(puId);
        };
        StartCoroutine(HandleRemove(ids, onRemove, false, delay));

        RemoveAllPairsWith(puId);
        exploding.Remove(puId);
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
        if (octopi == null) return;
        foreach (var octopus in octopi)
        {
            if (octopus == null || octopus.particleIds == null) continue;
            var headIds = new HashSet<int>();
            foreach (int id in octopus.particleIds)
                if (idToIndex.TryGetValue(id, out int idx) && inOctopusHead[idx]) headIds.Add(id);
            if (headIds.Count > 0) octopusHeadMidpoints[octopus.id] = GetAveragePositionFromIDs(headIds);
        }
    }

    private void UpdateMidpoints<T>(IEnumerable<T> items, Func<T, int> idGetter, Func<T, HashSet<int>> idsGetter, Unity.Collections.NativeHashMap<int, Unity.Mathematics.float2> map) where T : class
    {
        map.Clear();
        if (items == null) return;
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

    public bool TryGetPowerUp(int id, out PowerUp pu)
    {
        pu = null;
        return powerUpById.TryGetValue(id, out pu);
    }

    private void AddIgnorePair(int a, int b)
    {
        if (a < 0 || b < 0 || a == b || !ignorePairs.IsCreated) return;
        ignorePairs.TryAdd(PairKey(a, b), 1);
        ignorePairs.TryAdd(PairKey(b, a), 1);
    }

    private void RemoveAllPairsWith(int puId)
    {
        if (!ignorePairs.IsCreated) return;
        var keys = ignorePairs.GetKeyArray(Unity.Collections.Allocator.Temp);
        try
        {
            for (int i = 0; i < keys.Length; ++i)
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
        _lastJob.Complete();
        if (!powerUpById.TryGetValue(puId, out PowerUp pu) || pu == null) return;
        pu.Activate();
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
            yield return new UnityEngine.WaitForSeconds(chainDelay);
        }
        isProcessing = false;
    }

    /// <summary>
    /// True when <paramref name="pos"/> falls inside the expanding destruction band.
    /// <paramref name="bandType"/> is the detonating power-up's mergeIndex:
    /// 0 = horizontal row, 1 = cross (row or column), 2+ = full radial blast.
    /// </summary>
    private bool ShouldHitAtPosition(Unity.Mathematics.float2 pos, float currR,
                                     Unity.Mathematics.float2 origin, float prevR, int bandType, float halfThickness)
    {
        float dx = pos.x - origin.x;
        float dy = pos.y - origin.y;
        float dist = UnityEngine.Mathf.Sqrt(dx * dx + dy * dy);

        if (dist > currR) return false;
        if (dist <= prevR) return false;
        if (dist > destroyRadius) return false;

        if (bandType == 1)
        {
            if (UnityEngine.Mathf.Abs(dy) <= halfThickness) return true;
            return UnityEngine.Mathf.Abs(dx) <= halfThickness;
        }
        if (bandType != 0) return true;
        return UnityEngine.Mathf.Abs(dy) <= halfThickness;
    }

    private IEnumerator RadialDestroyRoutine(int rootId)
    {
        if (!TryGetPowerUp(rootId, out PowerUp root) || root == null) yield break;

        // Only particles that exist when the blast starts can be affected by it.
        var cohort = new HashSet<int>(ActiveCount);
        for (int i = 0; i < ActiveCount; ++i) cohort.Add(particleIds[i]);

        float halfThickness = destroyBandThickness * 0.5f;
        float startTime = UnityEngine.Time.time;
        var prevFrame = new HashSet<int>();
        var fading = new HashSet<int>();

        // ---- charge / telegraph phase: the band shape lights up before it detonates ----
        while (UnityEngine.Time.time - startTime < chargeDuration)
        {
            if (root == null) break;
            var origin = new Unity.Mathematics.float2(root.position.x, root.position.y);
            int bandType = root.mergeIndex;
            var frame = new HashSet<int>();

            for (int i = 0; i < ActiveCount; ++i)
            {
                int pid = particleIds[i];
                if (!cohort.Contains(pid)) continue;
                if (powerUpIds[i] == rootId) continue;

                float dx = positions[i].x - origin.x;
                float dy = positions[i].y - origin.y;
                float dist = UnityEngine.Mathf.Sqrt(dx * dx + dy * dy);
                if (dist > destroyRadius) continue;

                if (bandType == 1)
                {
                    if (!(UnityEngine.Mathf.Abs(dy) <= halfThickness || UnityEngine.Mathf.Abs(dx) <= halfThickness))
                        continue;
                }
                else if (bandType == 0)
                {
                    if (UnityEngine.Mathf.Abs(dy) > halfThickness) continue;
                }

                frame.Add(pid);
                if (idToIndex.TryGetValue(pid, out int idx))
                {
                    float a = emissionColors[idx].w + UnityEngine.Time.deltaTime * 0.5f;
                    if (a > 1f) a = 1f;
                    if (a < 0f) a = 0f;
                    emissionColors[idx] = new Unity.Mathematics.float4(1f, 0f, 0f, a);
                }
            }

            // Particles that dropped out of the band this frame fade their highlight back out.
            foreach (int pid in prevFrame)
                if (!frame.Contains(pid)) fading.Add(pid);

            var faded = new List<int>();
            foreach (int pid in fading)
            {
                if (!idToIndex.TryGetValue(pid, out int idx)) continue;
                float a = emissionColors[idx].w - UnityEngine.Time.deltaTime;
                if (a > 0f)
                {
                    emissionColors[idx] = new Unity.Mathematics.float4(1f, 0f, 0f, a);
                }
                else
                {
                    emissionColors[idx] = new Unity.Mathematics.float4(0f, 0f, 0f, 0f);
                    faded.Add(pid);
                }
            }
            foreach (int pid in faded) fading.Remove(pid);

            prevFrame = frame;
            yield return null;
        }

        foreach (int pid in prevFrame) ClearHighlight(pid);
        foreach (int pid in fading) ClearHighlight(pid);

        if (root == null) yield break;

        // ---- detonation ----
        var blastOrigin = new Unity.Mathematics.float2(root.position.x, root.position.y);
        int blastBandType = root.mergeIndex;

        AudioManager audioManager = global::Singleton<AudioManager>.Instance;
        if (audioManager != null)
        {
            audioManager.PlayClip("explode 1", new AudioClipSettings
            {
                volume = 0.5f,
                pitch = 1f,
                pitchVariance = 0.1f
            });
            audioManager.PlayClip("shatter", new AudioClipSettings
            {
                volume = 0.1f,
                pitchVariance = 0.2f
            });
        }

        OnDetonatePowerUp?.Invoke(root);
        global::TapticPlugin.TapticManager.Impact(global::TapticPlugin.ImpactFeedback.Heavy);
        RemovePowerUp(rootId);

        var dehoneyedBeeIds = new HashSet<int>();
        var processed = new HashSet<int>();
        var triggered = new HashSet<int> { rootId };
        float startDet = UnityEngine.Time.time;
        float prevR = 0f;

        while (UnityEngine.Time.time - startDet < destroyDuration)
        {
            float currR = destroyRadius * ((UnityEngine.Time.time - startDet) / destroyDuration);
            var toRemove = new HashSet<int>();
            var dehoneyedParticleIds = new HashSet<int>();

            for (int i = 0; i < ActiveCount; ++i)
            {
                int pid = particleIds[i];
                if (!cohort.Contains(pid)) continue;
                if (processed.Contains(pid)) continue;
                if (powerUpIds[i] == rootId) continue;
                if (!ShouldHitAtPosition(positions[i], currR, blastOrigin, prevR, blastBandType, halfThickness)) continue;

                processed.Add(pid);
                if (!idToIndex.TryGetValue(pid, out int idx)) continue;

                if (powerUpIds[idx] >= 0)
                {
                    int chainedId = powerUpIds[idx];
                    if (triggered.Add(chainedId)) RadialDestroy(chainedId);
                }
                else if (octopusIds[idx] >= 0)
                {
                    int octId = octopusIds[idx];
                    for (int k = 0; octopi != null && k < octopi.Count; ++k)
                    {
                        Octopus octopus = octopi[k];
                        if (octopus == null || octopus.id != octId) continue;
                        if (octopus.splitIndex >= 1)
                        {
                            octopus.Split();
                        }
                        else
                        {
                            UnityEngine.Vector2 headPos = octopusHeadMidpoints.TryGetValue(octId, out Unity.Mathematics.float2 mid)
                                ? new UnityEngine.Vector2(mid.x, mid.y)
                                : new UnityEngine.Vector2(positions[idx].x, positions[idx].y);
                            CollectionManager collectionManager = global::Singleton<CollectionManager>.Instance;
                            if (collectionManager != null) collectionManager.OnCollectOctopus(headPos);
                            RemoveOctopus(octopus);
                        }
                        break;
                    }
                }
                else if (caterpillarIds[idx] < 0)
                {
                    if (beeIds[idx] >= 0)
                    {
                        OnHitBeeParticle(idx, beeIds[idx], ref dehoneyedParticleIds, ref dehoneyedBeeIds);
                    }
                    else if (clumpIds[idx] >= 0)
                    {
                        int clumpId = clumpIds[idx];
                        for (int k = 0; clumps != null && k < clumps.Count; ++k)
                        {
                            if (clumps[k].id != clumpId) continue;
                            RemoveClump(clumps[k]);
                            break;
                        }
                    }
                    else if (isHoneyCoated[idx])
                    {
                        // Honey-coated jelly is only uncoated by the blast, never removed.
                        dehoneyedParticleIds.Add(pid);
                    }
                    else if (fishIds[idx] < 0 && !isWater[idx] && spongeIds[idx] < 0)
                    {
                        toRemove.Add(pid);
                    }
                }
            }

            RemoveHoneyCoating(dehoneyedParticleIds);
            if (toRemove.Count > 0) StartCoroutine(HandleRemove(toRemove));

            // Level blocks are hit by the same expanding band.
            GameManager game = Game;
            List<Block> blocks = (game != null && game.level != null) ? game.level.blocks : null;
            if (blocks != null)
            {
                for (int k = blocks.Count - 1; k >= 0; --k)
                {
                    Block block = blocks[k];
                    if (block == null) continue;
                    UnityEngine.Vector3 bp = block.transform.position;
                    if (!ShouldHitAtPosition(new Unity.Mathematics.float2(bp.x, bp.y), currR, blastOrigin, prevR, blastBandType, halfThickness))
                        continue;
                    block.OnPowerUpHit();
                }
            }

            prevR = currR;
            yield return null;
        }
    }

    private void ClearHighlight(int pid)
    {
        if (idToIndex.TryGetValue(pid, out int idx))
            emissionColors[idx] = new Unity.Mathematics.float4(0f, 0f, 0f, 0f);
    }

    /// <summary>
    /// Secondary effects of a jelly region being destroyed: nearby snow is washed away and nearby
    /// bees are hit. A snow region destroying itself does nothing.
    /// </summary>
    private void HandleSplashDestroy(HashSet<int> ids)
    {
        if (ids == null || ids.Count == 0) return;

        int seedId = 0;
        foreach (int first in ids) { seedId = first; break; }
        if (idToIndex.TryGetValue(seedId, out int seedIdx) && particleTypes[seedIdx] == snowFluidType) return;

        HashSet<int> snowHits = CollectNearbyParticles(ids, splashDestroyRadius, i => particleTypes[i] == snowFluidType);
        if (snowHits != null && snowHits.Count > 0)
            StartCoroutine(HandleRemove(snowHits, null, true, 0.2f));

        var dehoneyedParticleIds = new HashSet<int>();
        var dehoneyedBeeIds = new HashSet<int>();
        HashSet<int> beeHits = CollectNearbyParticles(ids, splashDestroyRadius, i => beeIds[i] >= 0);
        if (beeHits != null)
        {
            foreach (int id in beeHits)
                if (idToIndex.TryGetValue(id, out int idx))
                    OnHitBeeParticle(idx, beeIds[idx], ref dehoneyedParticleIds, ref dehoneyedBeeIds);
        }
        RemoveHoneyCoating(dehoneyedParticleIds);
    }

    /// <summary>
    /// Returns the ids of every particle satisfying <paramref name="includeIndex"/> (evaluated on the
    /// particle's index) that lies within <paramref name="r"/> of any of the <paramref name="sources"/>.
    /// Uses a uniform grid of cell size r, as the original did.
    /// </summary>
    private HashSet<int> CollectNearbyParticles(HashSet<int> sources, float r, Func<int, bool> includeIndex)
    {
        var result = new HashSet<int>();
        if (sources == null || sources.Count == 0 || ActiveCount <= 0) return result;

        float cell = UnityEngine.Mathf.Max(0.0001f, r);
        float inv = 1f / cell;
        float rSq = r * r;

        var grid = new Dictionary<UnityEngine.Vector2Int, List<int>>(ActiveCount);
        for (int i = 0; i < ActiveCount; ++i)
        {
            if (includeIndex != null && !includeIndex(i)) continue;
            var key = CellKey(positions[i], inv);
            if (!grid.TryGetValue(key, out List<int> bucket))
            {
                bucket = new List<int>();
                grid[key] = bucket;
            }
            bucket.Add(i);
        }
        if (grid.Count == 0) return result;

        foreach (int sourceId in sources)
        {
            if (!idToIndex.TryGetValue(sourceId, out int sourceIdx)) continue;
            Unity.Mathematics.float2 p = positions[sourceIdx];
            UnityEngine.Vector2Int c = CellKey(p, inv);
            for (int ox = -1; ox <= 1; ++ox)
            {
                for (int oy = -1; oy <= 1; ++oy)
                {
                    if (!grid.TryGetValue(new UnityEngine.Vector2Int(c.x + ox, c.y + oy), out List<int> bucket)) continue;
                    for (int k = 0; k < bucket.Count; ++k)
                    {
                        int j = bucket[k];
                        if (Unity.Mathematics.math.lengthsq(positions[j] - p) > rSq) continue;
                        result.Add(particleIds[j]);
                    }
                }
            }
        }
        return result;
    }

    public void OnHitBeeParticle(int idx, int beeId, ref HashSet<int> dehoneyedParticleIds, ref HashSet<int> dehoneyedBeeIds)
    {
        if (bees == null) return;
        Bee bee = null;
        for (int i = 0; i < bees.Count; ++i)
        {
            if (bees[i] != null && bees[i].id == beeId) { bee = bees[i]; break; }
        }
        if (bee == null) return;

        if (idx >= 0 && idx < ActiveCount && isHoneyCoated[idx])
        {
            // The bee is still encased in honey: strip the honey instead of collecting the bee.
            if (bee.solverIds != null)
            {
                for (int i = 0; i < bee.solverIds.Length; ++i) dehoneyedParticleIds.Add(bee.solverIds[i]);
            }
            dehoneyedBeeIds.Add(beeId);
            return;
        }

        if (!dehoneyedBeeIds.Contains(beeId))
        {
            CollectionManager collectionManager = global::Singleton<CollectionManager>.Instance;
            if (collectionManager != null) collectionManager.OnCollectBee(bee.position);
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
            float t = (UnityEngine.Time.time - start) / duration;
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
            if (idToIndex.TryGetValue(id, out int idx)) emissionColors[idx] = new Unity.Mathematics.float4(0f, g, 0f, a);
    }

    public FluidSolver()
    {
        usedFluidTypes = new HashSet<int>();
        powerUps = new List<PowerUp>();
        powerUpById = new Dictionary<int, PowerUp>();
        explosionQueue = new Queue<int>();
        octopi = new List<Octopus>();
        caterpillars = new List<Caterpillar>();
        bees = new List<Bee>();
        sponges = new List<Sponge>();
        _pendingRemovalIds = new HashSet<int>();
        merging = new Dictionary<int, PowerUpMergeData>();
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
        particleRadius = 0f;
        honeyRepelStrength = 0f;
        destroyDuration = 0.2f;
        chargeDuration = 0.5f;
        chainDelay = 0.5f;
        powerUpCohesionRadius = 0f;
        fishCohesionRadius = 0f;
        spongeCohesionRadius = 0.15f;
        spongeSpringStrength = 40f;
        octopusHeadParticleCount = 4;
        powerUpMergeDistance = 0.6f;
        mergeDuration = 0.5f;
        splashDestroyRadius = 0.4f;
        defaultGravity = Unity.Mathematics.float2.zero;
    }
}
