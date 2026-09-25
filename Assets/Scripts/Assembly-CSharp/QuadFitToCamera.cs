using UnityEngine;

[ExecuteAlways]
public class QuadFitToCamera : MonoBehaviour
{
    [Tooltip("If null, will use Camera.main")]
    public Camera targetCamera;

    private float _originalZScale;

    private void Awake()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main;
        }
        _originalZScale = transform.localScale.z;
    }

    private void LateUpdate()
    {
        if (targetCamera == null)
        {
            return;
        }

        if (!targetCamera.orthographic)
        {
            Debug.LogWarning("QuadFitToCamera requires an orthographic camera.");
            return;
        }

        float height = targetCamera.orthographicSize * 2f;
        transform.localScale = new Vector3(height * targetCamera.aspect, height, _originalZScale);

        Vector3 cameraPosition = targetCamera.transform.position;
        transform.position = new Vector3(cameraPosition.x, cameraPosition.y, transform.position.z);
    }
}
