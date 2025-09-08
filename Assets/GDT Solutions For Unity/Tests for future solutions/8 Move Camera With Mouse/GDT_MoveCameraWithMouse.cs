using UnityEngine;

public class GDT_MoveCameraWithMouse : MonoBehaviour
{
    Vector2 mouseInputVector;
    public float lookSensitivity = 2f;
    float lookVerticalMaxAngle = 90f;
    float incrementalClampedRotation = 0;
    public Transform cameraContainer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseInputVector.x = Input.GetAxis("Mouse X");
        mouseInputVector.y = Input.GetAxis("Mouse Y");
        incrementalClampedRotation += -mouseInputVector.y * lookSensitivity;
        incrementalClampedRotation = Mathf.Clamp(incrementalClampedRotation, -lookVerticalMaxAngle, lookVerticalMaxAngle);
        cameraContainer.transform.localRotation = Quaternion.Euler(incrementalClampedRotation, 0, 0);
        transform.rotation *= Quaternion.Euler(0, mouseInputVector.x * lookSensitivity, 0); 

    }
}
