using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Utility
{
    private static Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

    public static IEnumerator GetTexture(string id, string url, Action<Texture> callback)
    {
        if (_textures.TryGetValue(id, out Texture cached) && cached != null)
        {
            callback(cached);
            yield break;
        }

        using (UnityWebRequest www = UnityWebRequestTexture.GetTexture(url))
        {
            yield return www.SendWebRequest();
            if (www.responseCode == 200)
            {
                Texture2D texture = DownloadHandlerTexture.GetContent(www);
                _textures[id] = texture;
                callback(texture);
            }
            else
            {
                Debug.Log(www.error);
            }
        }
    }
}
