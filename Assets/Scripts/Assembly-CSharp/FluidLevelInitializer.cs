using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

/// <summary>
/// Helper component that initializes water particles when the level loads.
/// This fixes the issue where fluid doesn't display because Level.Init() 
/// (decompiled from Il2Cpp) doesn't spawn initial particles.
/// </summary>
public class FluidLevelInitializer : MonoBehaviour
{
    [Header("References")]
    public FluidSolver solver;
    public Water waterPrefab;
    
    [Header("Spawn Settings")]
    public int initialParticleCount = 512;
    public float spawnXRange = 4f;
    public float spawnYRange = 2f;
    public float particleSpacing = 0.4f;

    private bool _initialized;
    
    private void Start()
    {
        Initialize();
    }
    
    public void Initialize()
    {
        if (_initialized) return;
        _initialized = true;
        
        if (solver == null)
        {
            solver = FindObjectOfType<FluidSolver>();
        }
        
        if (solver == null)
        {
            Debug.LogError("[FluidLevelInitializer] FluidSolver not found!");
            return;
        }
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null && gameManager.waterPrefab != null)
        {
            waterPrefab = gameManager.waterPrefab;
        }
        
        SpawnInitialWater();
    }
    
    private void SpawnInitialWater()
    {
        if (solver == null) return;
        
        // Get collider bounds for spawning area
        GetSpawnBounds(out float minX, out float maxX, out float minY, out float maxY);
        
        // Calculate grid dimensions
        int cols = Mathf.RoundToInt((maxX - minX) / particleSpacing);
        int rows = Mathf.RoundToInt((maxY - minY) / particleSpacing);
        int totalCells = cols * rows;
        
        // Adjust particle count if needed
        int count = Mathf.Min(initialParticleCount, totalCells);
        if (count <= 0)
        {
            count = Mathf.Min(initialParticleCount, 100);
        }
        
        // Generate particle positions in a grid pattern
        var positions = new List<float2>(count);
        float spacingX = (maxX - minX) / Mathf.Max(cols, 1);
        float spacingY = (maxY - minY) / Mathf.Max(rows, 1);
        
        int particlesPerRow = Mathf.Min(cols, count);
        for (int i = 0; i < count; i++)
        {
            int row = i / particlesPerRow;
            int col = i % particlesPerRow;
            
            float x = minX + col * spacingX + spacingX * 0.5f;
            float y = minY + row * spacingY + spacingY * 0.5f;
            
            // Add some randomness
            x += UnityEngine.Random.Range(-spacingX * 0.3f, spacingX * 0.3f);
            y += UnityEngine.Random.Range(-spacingY * 0.3f, spacingY * 0.3f);
            
            positions.Add(new float2(x, y));
        }
        
        if (positions.Count == 0)
        {
            Debug.LogWarning("[FluidLevelInitializer] No positions generated for water particles");
            return;
        }
        
        // Water is type 0 (color fluids are types 0 to colorFluidTypes-1)
        int waterType = 0;
        
        // Add particles to solver
        HashSet<int> particleIds = solver.AddParticles(positions.ToArray(), waterType);
        
        if (particleIds != null && particleIds.Count > 0)
        {
            Debug.Log($"[FluidLevelInitializer] Spawned {particleIds.Count} water particles");
            
            // Create Water renderer instance if prefab exists
            if (waterPrefab != null)
            {
                Water waterInstance = Instantiate(waterPrefab, solver.transform);
                waterInstance.Init(solver, particleIds, waterType, FindObjectOfType<FluidCompute>());
            }
        }
        else
        {
            Debug.LogWarning("[FluidLevelInitializer] Failed to spawn water particles");
        }
    }
    
    private void GetSpawnBounds(out float minX, out float maxX, out float minY, out float maxY)
    {
        // Try to get bounds from Level's collider
        Level level = GetComponent<Level>();
        if (level != null)
        {
            level.GetColliderYExtents(out float colliderMinY, out float colliderMaxY);
            minY = colliderMinY + 1f;
            maxY = colliderMaxY - 1f;
            minX = -5f;
            maxX = 5f;
            return;
        }
        
        // Fallback bounds
        minX = -4f;
        maxX = 4f;
        minY = -2f;
        maxY = 4f;
    }
}