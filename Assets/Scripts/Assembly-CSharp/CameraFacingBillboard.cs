using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour
{
    public enum BillboardMode
    {
        Rotation = 0,
        LookAt = 1
    }

    public BillboardMode mode;

    private void LateUpdate()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            return;
        }

        Transform cameraTransform = mainCamera.transform;
        if (mode == BillboardMode.LookAt)
        {
            transform.LookAt(cameraTransform.position, Vector3.up);
            transform.Rotate(new Vector3(0f, 180f, 0f));
        }
        else if (mode == BillboardMode.Rotation)
        {
            Quaternion cameraRotation = cameraTransform.rotation;
            transform.LookAt(transform.position + cameraRotation * Vector3.forward, cameraRotation * Vector3.up);
        }
    }
}
