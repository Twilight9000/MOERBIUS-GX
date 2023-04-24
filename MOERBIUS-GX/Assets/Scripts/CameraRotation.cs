using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    //public Vector3 rotation;
    //public int speed = 5;

    CarControls controls;
    Vector2 rotate;

    // Start is called before the first frame update
    private void Awake()
    {
        controls = new CarControls();

        controls.car.RotateCamera.performed += cntxt => rotate = cntxt.ReadValue<Vector2>();
        controls.car.RotateCamera.canceled += cntxt => rotate = Vector2.zero;
    }

    public void OnCameraControls(InputValue value)
    {
        //Vector2 valueVect = value.Get<Vector2>();
        //transform.Rotate(valueVect.y * speed, 0, -valueVect.x * speed);
    }

    private void Update()
    {
        GetComponent<Transform>().Rotate(Vector3.up * rotate.x * -1f);
        GetComponent<Transform>().Rotate(Vector3.left * rotate.y * -1f);
    }

    private void OnEnable()
    {
        controls.car.Enable();
    }

    private void OnDisable()
    {
        controls.car.Disable();
    }
}