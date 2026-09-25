using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogScroller : MonoBehaviour
{
    [SerializeField]
    private GameObject _content;

    [HideInInspector]
    public List<string> texts = new List<string>();

    private string DATE_FORMAT = "HH:mm:ss";
    private int index;

    private void Start()
    {
    }

    public void ClearLogs()
    {
        texts.Clear();
        foreach (Transform child in _content.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void Log(string text)
    {
        index++;
        GameObject entry = new GameObject(index.ToString());
        entry.transform.parent = _content.transform;
        entry.transform.localPosition = Vector3.zero;
        entry.transform.localScale = Vector3.one;
        entry.transform.SetAsFirstSibling();

        string line = string.Format("[{0}] {1}", DateTime.Now.ToString(DATE_FORMAT), text);
        texts.Insert(0, line);

        Text label = entry.AddComponent<Text>();
        label.text = line;
        label.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        label.color = Color.white;
    }
}
