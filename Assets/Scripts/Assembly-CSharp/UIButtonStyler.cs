using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(SecondaryImageColor))]
public class UIButtonStyler : MonoBehaviour
{
    public UIButtonStyle buttonStyle;

    private Image image;
    private SecondaryImageColor secondaryImageColor;

    private void Awake()
    {
        image = GetComponent<Image>();
        secondaryImageColor = GetComponent<SecondaryImageColor>();
    }

    private void Start()
    {
        SetStyle(buttonStyle);
    }

    public void SetStyle(UIButtonStyle _buttonStyle)
    {
        buttonStyle = _buttonStyle;
        image.color = buttonStyle.topColor;
        secondaryImageColor.SecondaryColor = buttonStyle.bottomColor;
    }
}
