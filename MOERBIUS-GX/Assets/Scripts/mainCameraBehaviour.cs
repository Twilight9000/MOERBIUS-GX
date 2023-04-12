using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mainCameraBehaviour : MonoBehaviour
{
    public Vector3 cameraNewPos;
    public Vector3 cameraNewRot;

    public GameObject pivotPointObj;
    public PlayerInput pI;
    public InputAction hMove;
    public float rotatingXSpeed;
    public float hInput;

    public Vector3 playerPositionOffset;
    public Vector3 playerRotationOffset;


    // Start is called before the first frame update
    private void Awake()
    {
        pI.currentActionMap.Enable();

        hMove = pI.currentActionMap.FindAction("hMove");

        hMove.performed += ctx => hInput = ctx.ReadValue<float>();
        hMove.canceled += ctx => hInput = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(pivotPointObj.transform.position, new Vector3(0, 0, 1), hInput * rotatingXSpeed);

        /*
        cameraNewPos = new Vector3(player.transform.position.x + playerPositionOffset.x, player.transform.position.y + playerPositionOffset.y, player.transform.position.z + playerPositionOffset.z);

        cameraNewRot = new Vector3(player.transform.rotation.x + playerRotationOffset.x, player.transform.rotation.y + playerRotationOffset.y, player.transform.rotation.z + playerRotationOffset.z);

        transform.position = cameraNewPos;
        transform.rotation = Quaternion.Euler(cameraNewRot);
        */
    }
}
