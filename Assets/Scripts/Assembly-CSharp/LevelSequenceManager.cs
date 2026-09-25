using UnityEngine;

[ExecuteAlways]
public class LevelSequenceManager : Singleton<LevelSequenceManager>
{
    public Level[] onboardingLevelPrefabs;
    public Level[] repeatLevelPrefabs;
    public Level testLevelPrefab;
    public string testLevelPrefabPath;
    public Level level;

    public Level GetLevelPrefab(int index)
    {
        if (index < onboardingLevelPrefabs.Length)
        {
            return onboardingLevelPrefabs[index];
        }

        int repeatIndex = (index - onboardingLevelPrefabs.Length) % repeatLevelPrefabs.Length;
        return repeatLevelPrefabs[repeatIndex];
    }
}
