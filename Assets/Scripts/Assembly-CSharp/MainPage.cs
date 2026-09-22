using UnityEngine;

public class MainPage : MonoBehaviour
{
    [SerializeField]
    private Menu _menu;

    private LogScroller _logScroller;

    private void Awake()
    {
        Transform root = transform.root;
        _logScroller = root != null ? root.GetComponent<LogScroller>() : null;

        if (_logScroller != null)
        {
            _logScroller.Log(Application.identifier);
        }
    }

    public void OnNavBtnClick(string pageName)
    {
        if (_menu == null)
        {
            return;
        }

        _menu.NavToPage(pageName);
    }

    private void _LogText(string text)
    {
        if (_logScroller != null)
        {
            _logScroller.Log(text);
        }
    }
}
