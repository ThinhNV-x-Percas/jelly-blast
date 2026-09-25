using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteAlways]
public class HorizontalFOV : MonoBehaviour
{
    public float targetWidth;

    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
        if (cam.orthographic && targetWidth <= 0f)
        {
            targetWidth = cam.orthographicSize * cam.aspect * 2f;
        }
    }

    private void Update()
    {
        if (cam.orthographic)
        {
            cam.orthographicSize = targetWidth / (cam.aspect * 2f);
        }
    }
}
