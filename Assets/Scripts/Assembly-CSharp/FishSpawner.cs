using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField]
    private int fishCount = 1;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += SpawnFish;
    }

    private void SpawnFish()
    {
        for (int i = 0; i < fishCount; i++)
            Singleton<GameManager>.Instance.solver.AddFish(transform.position);
    }
}
