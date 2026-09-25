using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

[CreateAssetMenu(fileName = "ApplicationData", menuName = "Custom/ApplicationData", order = 1)]
public class ApplicationData : ScriptableObject
{
    private const string playerDataFileName = "playerData";

    public PlayerData playerData;

    private static string PlayerDataPath => Path.Combine(Application.persistentDataPath, playerDataFileName + ".json");

    public void SavePlayerData()
    {
        if (playerData == null)
        {
            return;
        }

        string path = PlayerDataPath;
        string tempPath = path + ".tmp";
        try
        {
            // Write to a temp file first so a crash mid-write cannot leave a truncated save behind.
            File.WriteAllText(tempPath, JsonConvert.SerializeObject(playerData, Formatting.Indented));
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Move(tempPath, path);
        }
        catch (Exception e)
        {
            Debug.LogWarning($"Failed to save player data: {e}");
        }
    }

    public void LoadPlayerData()
    {
        string path = PlayerDataPath;
        PlayerData loaded = null;
        bool exists = false;
        try
        {
            // Recover from a save interrupted between deleting the old file and moving the new one in.
            string tempPath = path + ".tmp";
            if (!File.Exists(path) && File.Exists(tempPath))
            {
                File.Move(tempPath, path);
            }

            exists = File.Exists(path);
            if (exists)
            {
                loaded = JsonConvert.DeserializeObject<PlayerData>(File.ReadAllText(path));
            }
        }
        catch (Exception e)
        {
            Debug.LogWarning($"Failed to load player data, resetting: {e}");
        }

        if (loaded != null)
        {
            playerData = loaded;
            return;
        }

        if (exists)
        {
            Debug.LogWarning("Player data file was empty or corrupt, resetting.");
            try
            {
                File.Copy(path, path + ".corrupt", true);
            }
            catch (Exception)
            {
            }
        }
        playerData = new PlayerData();
        SavePlayerData();
    }

    public void ClearPlayerData()
    {
        try
        {
            string path = PlayerDataPath;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        catch (Exception e)
        {
            Debug.LogWarning($"Failed to delete player data: {e}");
        }
        playerData = new PlayerData();
        SavePlayerData();
    }
}
