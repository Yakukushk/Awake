using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensentive = 30f;
    public float RotationX = 0f;
    public Transform transForm;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensentive * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensentive * Time.deltaTime;
        RotationX -= MouseY;
        RotationX = Mathf.Clamp(RotationX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(RotationX, 0f, 0f);
        transForm.Rotate(Vector3.up * MouseX);
    }
}
