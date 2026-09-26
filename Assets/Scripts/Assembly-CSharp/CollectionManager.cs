using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

/// <summary>
/// Reconstructed CollectionManager.
/// The original source was generated from IL2CPP and contained invalid IL/native reconstruction
/// artifacts. This version preserves the gameplay-facing responsibilities while replacing the
/// broken generated code with normal C#.
/// </summary>
public class CollectionManager : Singleton<CollectionManager>
{
    private FluidSolver solver;
    private Level level;

    public FluidCompute lowResCompute;

    public FluidCollectDisplay colorDisplay;
    public FluidCollectDisplay mudDisplay;
    public FluidCollectDisplay honeyDisplay;
    public FluidCollectDisplay snowDisplay;
    public SpriteCollectDisplay spriteDisplay;

    // The original game obtains this prefab through another singleton. Keeping an explicit
    // reference makes the reconstructed code deterministic while still allowing automatic lookup.
    [SerializeField] private Butterfly butterflyPrefab;

    private GameManager gameManager;

    private void Awake()
    {
        // The level is instantiated in GameManager.Start, so initialisation waits for OnInit.
        gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null)
            gameManager.OnInit += Init;
    }

    private void OnDestroy()
    {
        if (gameManager != null)
            gameManager.OnInit -= Init;
    }

    private void Init()
    {
        solver = gameManager.solver;
        level = gameManager.level;

        if (solver == null)
            return;

        solver.OnStartRemoveParticles -= OnSolverStartRemoveParticles;
        solver.OnStartRemoveParticles += OnSolverStartRemoveParticles;

        solver.OnCreatePowerup -= OnCreatePowerup;
        solver.OnCreatePowerup += OnCreatePowerup;

        InitDisplay(colorDisplay, null, gameManager.colorMaterial);
        InitDisplay(mudDisplay, solver.mudFluidType, gameManager.mudMaterial);
        InitDisplay(honeyDisplay, solver.honeyFluidType, gameManager.honeyMaterial);
        InitDisplay(snowDisplay, solver.snowFluidType, gameManager.snowMaterial);
    }

    private void InitDisplay(FluidCollectDisplay display, int? fluidType, Material sourceMaterial)
    {
        if (display == null)
            return;

        if (fluidType.HasValue)
            display.fluidType = fluidType.Value;

        if (lowResCompute != null && display.mr != null)
            display.mr.material = CloneMaterialLowRes(sourceMaterial != null ? sourceMaterial : display.mr.sharedMaterial);

        display.Init();
    }

    public Material CloneMaterialLowRes(Material mat)
    {
        if (mat == null)
            return null;

        Material material = new Material(mat);

        if (lowResCompute == null)
            return material;

        SetTextureIfPresent(material, lowResCompute.emissionRT,
            "_EmissionRT", "_EmissionTex", "_EmissionTexture", "EmissionRT", "EmissionTex");

        SetTextureIfPresent(material, lowResCompute.fluidRT,
            "_FluidRT", "_FluidTex", "_FluidTexture", "FluidRT", "FluidTex");

        SetTextureIfPresent(material, lowResCompute.rawFieldRT,
            "_RawFieldRT", "_RawFieldTex", "_RawFieldTexture", "RawFieldRT", "RawFieldTex");

        return material;
    }

    private static void SetTextureIfPresent(Material material, Texture texture, params string[] propertyNames)
    {
        if (material == null || texture == null || propertyNames == null)
            return;

        for (int i = 0; i < propertyNames.Length; i++)
        {
            string propertyName = propertyNames[i];
            if (!string.IsNullOrEmpty(propertyName) && material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, texture);
                return;
            }
        }
    }

    public void OnCreatePowerup(HashSet<int> ids, Vector2 targetPos)
    {
        if (ids == null || ids.Count == 0 || solver == null || colorDisplay == null)
            return;

        if (colorDisplay.activeCount >= colorDisplay.maxParticles)
            return;

        foreach (int id in ids)
        {
            if (!solver.idToIndex.TryGetValue(id, out int index))
                continue;

            if (index < 0 || index >= solver.ActiveCount)
                continue;

            Vector2 position = solver.positions[index];
            Vector2 velocity = solver.velocities[index];
            int particleType = solver.particleTypes[index];

            if (colorDisplay.activeCount >= colorDisplay.maxParticles)
                break;

            // Native reconstruction shows mode 2 (Shrink), zero duration and a captured target
            // position callback.
            Func<Vector2> getTargetPosition = () => targetPos;
            colorDisplay.AddParticle(
                position,
                velocity,
                particleType,
                CollectParticleMode.Shrink,
                0f,
                getTargetPosition,
                null);
        }
    }

    public void OnSolverStartRemoveParticles(HashSet<int> ids, bool explode)
    {
        if (solver == null || ids == null || ids.Count == 0)
        {
            GameManager.Instance?.CheckWinCondition();
            return;
        }

        if (level == null)
            level = FindObjectOfType<Level>();

        foreach (int id in ids)
        {
            if (!solver.idToIndex.TryGetValue(id, out int index))
                continue;

            if (index < 0 || index >= solver.ActiveCount)
                continue;

            int particleType = solver.particleTypes[index];
            float2 position = solver.positions[index];
            float2 velocity = solver.velocities[index];

            if (level != null && level.goals != null)
            {
                // The original routine iterates through every active goal and asks TryCollect
                // whether this particle satisfies it.
                for (int goalIndex = 0; goalIndex < level.goals.Count; goalIndex++)
                {
                    GoalData goal = level.goals[goalIndex];
                    if (goal == null)
                        continue;

                    int goalSlot = goalIndex;
                    TryCollect(
                        goal,
                        particleType,
                        position,
                        velocity,
                        () => GoalWorldPosition(goalSlot),
                        () => ReceiveGoalParticle(goalSlot));
                }
            }

            if (level != null && level.sections != null && level.sections.Count >= 1)
            {
                // Locks belonging to the currently active level section can also be fed by
                // collected particles; each lock reports the goal it is guarding and its own
                // collection-point/callback so the particle flies to the lock instead of a goal.
                LevelSection currentSection = level.GetCurrentSection();
                if (currentSection != null && currentSection.locks != null && currentSection.locks.Count >= 1)
                {
                    foreach (Lock lockObj in currentSection.locks)
                    {
                        if (lockObj == null)
                            continue;

                        TryCollect(
                            lockObj.goalData,
                            particleType,
                            position,
                            velocity,
                            () => lockObj.collectionPoint.position,
                            lockObj.RecieveParticle);
                    }
                }
            }

            if (explode)
                AddExplodeParticle(position, velocity, particleType);
        }

        GameManager.Instance?.CheckWinCondition();
    }

    private Vector2 GoalWorldPosition(int index)
    {
        GameplayScreen screen = Viewport.GetViewport<GameplayScreen>();
        return screen != null && screen.goals != null && index < screen.goals.Length
            ? screen.GetWorldGoalPosition(index)
            : (Vector2)transform.position;
    }

    private void ReceiveGoalParticle(int index)
    {
        GameplayScreen screen = Viewport.GetViewport<GameplayScreen>();
        if (screen == null || screen.goals == null || index >= screen.goals.Length || screen.goals[index] == null)
            return;

        screen.goals[index].RecieveParticle();
    }

    private void TryCollect(
        GoalData goal,
        int particleType,
        float2 position,
        float2 velocity,
        Func<Vector2> targetPosition,
        Action onCollected)
    {
        if (goal == null || goal.count < 1 || solver == null)
            return;

        FluidCollectDisplay display = null;

        if (goal.goalType == GoalType.Snow && solver.snowFluidType == particleType)
        {
            display = snowDisplay;
        }
        else if (goal.goalType == GoalType.Mud && solver.mudFluidType == particleType)
        {
            display = mudDisplay;
        }
        else if (goal.goalType == GoalType.Fluid && goal.fluidType == particleType)
        {
            display = colorDisplay;
        }
        else
        {
            // Not taken by this goal (e.g. the level's goal is bees): the native code still feeds the
            // level's bee spawner with every colour/mud/snow particle. This branch was lost, so bee
            // levels that spawn extra bees from collected fluid (level 7.5) never spawned any.
            bool isFluid = particleType < solver.colorFluidTypes
                || particleType == solver.mudFluidType
                || particleType == solver.snowFluidType;
            if (isFluid && level != null && level.EnableBeeSpawning)
                level.OnFluidCollected(particleType);
            return;
        }

        Vector2 pos = position;
        Vector2 vel = velocity;

        if (display != null && display.activeCount < display.maxParticles)
        {
            display.AddParticle(
                pos,
                vel,
                particleType,
                default,
                0f,
                targetPosition,
                onCollected);
        }
        else
        {
            // No free flying particle to deliver it: credit the goal/lock straight away, otherwise
            // its displayed counter never reaches zero (a lock would never open).
            onCollected?.Invoke();
        }

        goal.count--;
        level?.OnFluidCollected(particleType);
    }

    private void AddExplodeParticle(float2 position, float2 velocity, int particleType)
    {
        if (solver == null)
            return;

        FluidCollectDisplay display;

        if (solver.colorFluidTypes > particleType)
        {
            display = colorDisplay;
        }
        else if (solver.mudFluidType == particleType)
        {
            display = mudDisplay;
        }
        else if (solver.snowFluidType == particleType)
        {
            display = snowDisplay;
        }
        else
        {
            return;
        }

        if (display == null || display.activeCount >= display.maxParticles)
            return;

        float duration = UnityEngine.Random.Range(
            display.minExplodeDuration,
            display.maxExplodeDuration);

        display.AddParticle(
            position,
            velocity,
            particleType,
            CollectParticleMode.Explode,
            duration);
    }

    public void OnCollectIceBlock(Vector2 pos, Vector2 vel)
    {
        if (level == null)
            return;

        for (int i = 0; i < level.goals.Count; i++)
        {
            GoalData goal = level.goals[i];
            if (goal == null || goal.count < 1 || goal.goalType != GoalType.Ice)
                continue;

            int index = i;
            if (spriteDisplay != null)
                spriteDisplay.AddSprite(goal.sprite, pos, vel, 0.1f, () => GoalWorldPosition(index), () => ReceiveGoalParticle(index));

            goal.count--;
        }

        GameManager.Instance?.CheckWinCondition();
    }

    public void OnCollectOctopus(Vector2 pos)
    {
        CollectSpriteGoal(GoalType.Octopus, pos, Vector2.zero, 0f);
    }

    public void OnCollectBee(Vector2 pos)
    {
        CollectSpriteGoal(GoalType.Bee, pos, Vector2.zero, 0f);
    }

    public void OnCollectStoneBlock(Vector2 pos, Vector2 vel)
    {
        CollectSpriteGoal(GoalType.Stone, pos, vel, 0.1f);
    }

    public void OnCollectCaterpillar(Vector2 pos)
    {
        if (level == null)
            return;

        for (int i = 0; i < level.goals.Count; i++)
        {
            GoalData goal = level.goals[i];
            if (goal == null || goal.count < 1 || goal.goalType != GoalType.Butterfly)
                continue;

            int goalSlot = i;
            Butterfly butterfly = CreateButterfly();
            if (butterfly != null)
            {
                butterfly.transform.SetParent(transform, false);
                butterfly.transform.position = new Vector3(pos.x, pos.y, 0f);
                butterfly.Init(pos, () => GoalWorldPosition(goalSlot), () => ReceiveGoalParticle(goalSlot));
            }

            goal.count--;
        }

        GameManager.Instance?.CheckWinCondition();
    }

    private void CollectSpriteGoal(GoalType type, Vector2 pos, Vector2 vel, float duration)
    {
        if (level == null)
            return;

        for (int i = 0; i < level.goals.Count; i++)
        {
            GoalData goal = level.goals[i];
            if (goal == null || goal.count < 1 || goal.goalType != type)
                continue;

            int index = i;
            if (spriteDisplay != null)
                spriteDisplay.AddSprite(goal.sprite, pos, vel, duration, () => GoalWorldPosition(index), () => ReceiveGoalParticle(index));

            goal.count--;
        }

        GameManager.Instance?.CheckWinCondition();
    }

    private Butterfly CreateButterfly()
    {
        if (butterflyPrefab != null)
            return Instantiate(butterflyPrefab);

        // Fallback for projects where the prefab is stored in a Resources asset or was exposed
        // through another manager but its original field name was lost during decompilation.
        Butterfly[] assets = Resources.FindObjectsOfTypeAll<Butterfly>();
        for (int i = 0; i < assets.Length; i++)
        {
            Butterfly candidate = assets[i];
            if (candidate == null)
                continue;

            if (!candidate.gameObject.scene.IsValid())
                return Instantiate(candidate);
        }

        return null;
    }

    public void OnRemoveHoney(HashSet<int> ids)
    {
        if (ids == null || ids.Count == 0 || solver == null || honeyDisplay == null)
            return;

        foreach (int id in ids)
        {
            if (!solver.idToIndex.TryGetValue(id, out int index))
                continue;

            if (index < 0 || index >= solver.ActiveCount)
                continue;

            if (honeyDisplay.activeCount >= honeyDisplay.maxParticles)
                continue;

            Vector2 position = solver.positions[index];
            Vector2 velocity = solver.velocities[index];
            float duration = UnityEngine.Random.Range(
                honeyDisplay.minExplodeDuration,
                honeyDisplay.maxExplodeDuration);

            honeyDisplay.AddParticle(
                position,
                velocity,
                solver.honeyFluidType,
                CollectParticleMode.Explode,
                duration);
        }
    }
}
