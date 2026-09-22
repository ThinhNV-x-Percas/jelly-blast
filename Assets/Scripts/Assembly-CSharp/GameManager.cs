using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameState _gameState;

    private Action<GameState, GameState> m_OnGameStateChanged;

    public FluidSolver solver;
    public FluidPhysicsCoupler coupler;
    public FluidDisplay display;

    public int targetParticleCount;

    [Tooltip("Number of coloured particles that must spawn before a new fish appears")]
    [Header("Fish Spawn Settings")]
    public int fishSpawnThreshold;

    private int _particlesSpawnedSinceLastFish;
    private int _fishSpawnedCount;
    private int _activeFishCount;
    private int _fishGoalTarget;

    public float selectionRadius;
    public int minRemoveParticles;
    public float powerUpMergeDistance;

    [Header("Lighting")]
    public Vector3 lightRot;

    public Level level;

    public Action OnUserMove;
    public Action<HashSet<int>> OnRejectInput;
    public Action OnInit;
    public Action<Vector2> OnTooSmallReject;

    public int coinsCollected;

    public List<Water> waters;

    public Mud mudPrefab;
    public Snow snowPrefab;
    public Water waterPrefab;
    public Sponge spongePrefab;
    public Octopus octopusPrefab;
    public Caterpillar caterpillarPrefab;
    public Bee beePrefab;
    public Ice icePrefab;
    public Stone stonePrefab;
    public Fish fishPrefab;
    public Butterfly butterflyPrefab;
    public FluidCompute compute;

    public float failTimerDuration;
    public Honey honeyTest;
    public FluidCollectDisplay mudCollectDisplay;

    public Material mudMaterial;
    public Material honeyMaterial;
    public Material snowMaterial;
    public Material colorMaterial;
    public Material octopusMaterial;
    public Material beeMaterial;

    public Light light;
    public SplashEffect splashEffectPrefab;
    public List<ParticleQueueData> particleQueue;

    private int queuedCount;

    [NonSerialized]
    public int pendingFish;

    public GameState gameState
    {
        get => _gameState;
        set
        {
            if (_gameState == value)
            {
                return;
            }

            _gameState = value;
            m_OnGameStateChanged?.Invoke(_gameState, value);
        }
    }

    public event Action<GameState, GameState> OnGameStateChanged
    {
        add => m_OnGameStateChanged += value;
        remove => m_OnGameStateChanged -= value;
    }

    private void Start()
    {
        ApplicationData appData = ApplicationManager.appData;
        PlayerData playerData = appData.playerData;

        Level levelPrefab = Singleton<LevelSequenceManager>.Instance.GetLevelPrefab(playerData.levelIndex);
        level = Instantiate(levelPrefab);
        level.transform.SetParent(transform);

        level.Init();
        coupler.Init();
        display.Init();
        honeyTest.Init();

        gameState = GameState.EstablishingShot;

        Singleton<UIIconGenerator>.Instance.UpdateIcons();
        OnInit?.Invoke();
    }

    private IEnumerator HandleIntro()
    {
        yield return new WaitForSeconds(4f);

        if (_gameState != GameState.Gameplay)
        {
            _gameState = GameState.Gameplay;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.Gameplay);
        }
    }

    public void OnClickUserInputPanel(Vector2 mousePos)
    {
        // Leaving EstablishingShot / IntroScreen transitions the game into Gameplay.
        if (_gameState != GameState.Gameplay)
        {
            _gameState = GameState.Gameplay;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.Gameplay);
        }

        if (level == null || level.moveCount < 1 || solver == null)
        {
            return;
        }

        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            return;
        }

        Vector3 cameraPosition = mainCamera.transform.position;
        Vector3 screenPosition = new Vector3(mousePos.x, mousePos.y, -cameraPosition.z);
        Vector3 worldPosition3D = mainCamera.ScreenToWorldPoint(screenPosition);
        Vector2 worldPosition = worldPosition3D;

        int particleIndex = solver.FindClosestParticle(worldPosition, selectionRadius);
        if (particleIndex < 0)
        {
            return;
        }

        HashSet<int> region = solver.FindContiguousRegionIndices(particleIndex);
        if (region == null)
        {
            return;
        }

        // Do not interact with particles belonging to special objects.
        if (solver.fishIds.IsCreated && solver.fishIds[particleIndex] != -1)
        {
            RejectInput(region, worldPosition3D);
            return;
        }

        if (solver.octopusIds.IsCreated && solver.octopusIds[particleIndex] != -1)
        {
            RejectInput(region, worldPosition3D);
            return;
        }

        if (solver.powerUpIds.IsCreated)
        {
            int powerUpId = solver.powerUpIds[particleIndex];
            if (powerUpId != -1)
            {
                solver.RadialDestroy(powerUpId);
                TapticPlugin.TapticManager.Impact(TapticPlugin.ImpactFeedback.Heavy);
                TakeMove();
                return;
            }
        }

        if (solver.spongeIds.IsCreated && solver.spongeIds[particleIndex] != -1)
        {
            RejectInput(region, worldPosition3D);
            return;
        }

        if (solver.isWater.IsCreated && solver.isWater[particleIndex])
        {
            RejectInput(region, worldPosition3D);
            return;
        }

        if (solver.isHoneyCoated.IsCreated && solver.isHoneyCoated[particleIndex])
        {
            RejectInput(region, worldPosition3D);
            return;
        }

        if (solver.particleTypes.IsCreated && solver.particleTypes[particleIndex] > 7)
        {
            RejectInput(region, worldPosition3D);
            return;
        }

        if (region.Count > minRemoveParticles)
        {
            solver.UserRemoveRegion(region, particleIndex, worldPosition, 0.3f);
            TakeMove();
        }
        else
        {
            OnTooSmallReject?.Invoke(worldPosition);
        }

        TapticPlugin.TapticManager.Impact(TapticPlugin.ImpactFeedback.Medium);
        Singleton<AudioManager>.Instance.PlayClip("pop");

        if (region.Count > minRemoveParticles)
        {
            return;
        }

        RejectInput(region, worldPosition3D);
    }

    private void RejectInput(HashSet<int> region, Vector3 worldPosition)
    {
        OnRejectInput?.Invoke(region);
        solver.StartRejectFlash(region);

        if (splashEffectPrefab == null)
        {
            return;
        }

        SplashEffect splashEffect = Instantiate(splashEffectPrefab);
        if (splashEffect != null)
        {
            splashEffect.transform.position = worldPosition;
            Destroy(splashEffect.gameObject, 0.5f);
        }
    }

    private void Update()
    {
        if (light != null)
        {
            Vector3 forward = light.transform.forward;
            Shader.SetGlobalVector("_LightDirection", new Vector4(forward.x, forward.y, forward.z, 0f));
        }

        if (level == null || solver == null || particleQueue == null)
        {
            return;
        }

        if (level.shouldSpawnParticles)
        {
            int activeAndQueued = queuedCount + solver.ActiveCount;
            if (activeAndQueued < targetParticleCount)
            {
                int count = UnityEngine.Random.Range(4, 7);
                particleQueue.Add(new ParticleQueueData
                {
                    count = count,
                    time = Time.time
                });
                queuedCount += count;
            }
        }

        if (_gameState != GameState.IntroScreen && _gameState != GameState.Gameplay)
        {
            return;
        }

        if (particleQueue.Count == 0)
        {
            return;
        }

        ParticleQueueData queueData = particleQueue[0];
        if (Time.time <= queueData.time)
        {
            return;
        }

        LevelSection currentSection = null;
        if (level.sections != null && level.currentSection >= 0 && level.currentSection < level.sections.Count)
        {
            currentSection = level.sections[level.currentSection];
        }

        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            return;
        }

        float cameraHeight = mainCamera.orthographicSize;
        float sectionY = currentSection != null ? currentSection.y : 0f;
        float spawnBaseY = sectionY + cameraHeight;

        float spawnBaseX;
        float spread;
        if (level.fluidSpawnMode == FluidSpawnMode.CustomRange)
        {
            spawnBaseX = UnityEngine.Random.Range(level.fluidSpawnXRange.x, level.fluidSpawnXRange.y);
            spread = 0.2f;
        }
        else
        {
            float halfWidth = cameraHeight * mainCamera.aspect;
            spawnBaseX = UnityEngine.Random.Range(-halfWidth, halfWidth);
            spread = 2f;
        }

        Vector2 baseOffset = UnityEngine.Random.insideUnitCircle;
        float centerX = spawnBaseX + baseOffset.x * spread;
        float centerY = spawnBaseY + 2f + baseOffset.y * spread;
        int type = level.colors != null && level.colors.Length > 0
            ? UnityEngine.Random.Range(0, level.colors.Length)
            : 0;

        Unity.Mathematics.float2[] positions = new Unity.Mathematics.float2[queueData.count];
        for (int i = 0; i < queueData.count; i++)
        {
            Vector2 offset = UnityEngine.Random.insideUnitCircle * 0.15f;
            positions[i] = new Vector2(centerX + offset.x, centerY + offset.y);
        }

        solver.AddClump(positions, type);

        _particlesSpawnedSinceLastFish += queueData.count;

        if (ShouldSpawnFish() && _particlesSpawnedSinceLastFish >= fishSpawnThreshold)
        {
            Fish fish = solver.AddFish(new Vector2(centerX, spawnBaseY));
            if (fish != null)
            {
                _activeFishCount++;
                fish.OnMenuReached += OnFishReachedMenu;
            }

            _particlesSpawnedSinceLastFish = 0;
            _fishSpawnedCount++;
        }

        particleQueue.RemoveAt(0);
        queuedCount -= queueData.count;
    }

    private void OnFishReachedMenu()
    {
        _activeFishCount--;
    }

    private void TakeMove()
    {
        if (level == null)
        {
            return;
        }

        level.moveCount--;
        OnUserMove?.Invoke();

        if (level.moveCount == 0)
        {
            StartCoroutine(MonitorFailCondition());
        }
    }

    private IEnumerator MonitorFailCondition()
    {
        float startFailTimerTime = Time.time;

        while (_gameState == GameState.Gameplay)
        {
            if (Time.time >= startFailTimerTime + failTimerDuration)
            {
                if (_gameState == GameState.Gameplay)
                {
                    Fail();
                }
                yield break;
            }

            if (solver != null && solver.exploding != null && solver.exploding.Count != 0)
            {
                startFailTimerTime = Time.time;
            }

            yield return null;
        }
    }

    public void CheckWinCondition()
    {
        if (_gameState != GameState.Gameplay || level == null || level.goals == null)
        {
            return;
        }

        for (int i = 0; i < level.goals.Count; i++)
        {
            GoalData goal = level.goals[i];
            if (goal != null && goal.count > 0)
            {
                return;
            }
        }

        Win();
    }

    public void StartIntroScreen()
    {
        if (_gameState != GameState.IntroScreen)
        {
            _gameState = GameState.IntroScreen;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.IntroScreen);
        }

        StartCoroutine(HandleIntro());
    }

    public void EndIntro()
    {
        if (_gameState != GameState.Gameplay)
        {
            _gameState = GameState.Gameplay;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.Gameplay);
        }
    }

    public void Win()
    {
        if (_gameState != GameState.Win)
        {
            _gameState = GameState.Win;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.Win);
        }

        ApplicationData appData = ApplicationManager.appData;
        PlayerData playerData = appData.playerData;
        playerData.levelIndex++;

        coinsCollected = UnityEngine.Random.Range(50, 100);
        playerData.coinCount += coinsCollected;

        appData.SavePlayerData();
    }

    public void Fail()
    {
        if (_gameState != GameState.Fail)
        {
            _gameState = GameState.Fail;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.Fail);
        }
    }

    public void Reset()
    {
        if (_gameState != GameState.None)
        {
            _gameState = GameState.None;
            m_OnGameStateChanged?.Invoke(_gameState, GameState.None);
        }

        Singleton<ApplicationManager>.Instance.ReloadActiveScene();
    }

    private void CheckFishHitWater()
    {
        if (solver == null || level == null || solver.fishes == null || level.goals == null)
        {
            return;
        }

        foreach (Fish fish in solver.fishes)
        {
            if (fish == null || fish.particleIds == null)
            {
                continue;
            }

            bool hitWater = false;
            foreach (int particleId in fish.particleIds)
            {
                if (solver.idToIndex.TryGetValue(particleId, out int index) && solver.waterDensities[index] > 0f)
                {
                    hitWater = true;
                    break;
                }
            }

            if (!hitWater)
            {
                continue;
            }

            for (int i = 0; i < level.goals.Count; i++)
            {
                GoalData goalData = level.goals[i];
                if (goalData != null && goalData.goalType == GoalType.Fish && goalData.count >= 1)
                {
                    Vector2 worldGoalPosition = Viewport.GetViewport<GameplayScreen>().GetWorldGoalPosition(i);
                    fish.PlayHitWaterAnimation(worldGoalPosition);
                    break;
                }
            }
        }
    }

    private bool ShouldSpawnFish()
    {
        if (level == null || level.disableAutoFishSpawning || level.goals == null)
        {
            return false;
        }

        GoalData goalData = level.goals.Find(g => g != null && g.goalType == GoalType.Fish);
        if (goalData == null)
        {
            return false;
        }

        if (_fishGoalTarget == 0)
        {
            _fishGoalTarget = goalData.count;
        }

        return _fishSpawnedCount < _fishGoalTarget;
    }

    public GameManager()
    {
        targetParticleCount = 0;
        fishSpawnThreshold = 300;
        selectionRadius = 0.5f;
        powerUpMergeDistance = 1f;
        coinsCollected = 100;
        waters = new List<Water>();
        failTimerDuration = 3f;
        particleQueue = new List<ParticleQueueData>();
    }
}
