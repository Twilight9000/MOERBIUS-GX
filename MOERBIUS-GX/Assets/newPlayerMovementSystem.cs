using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newPlayerMovementSystem : MonoBehaviour
{
    public Rigidbody rb;
    public float hInput;
    public float moveSpeed;
    public float forwardSpeed;
    public float gravityScale = 5;
    public static float globalGravity = -9.81f;

    public PlayerInput pI;
    public InputAction hMove;

    private void Awake()
    {
        pI = GetComponent<PlayerInput>();

        pI.currentActionMap.Enable();

        hMove = pI.currentActionMap.FindAction("hMove");

        hMove.performed += ctx => hInput = ctx.ReadValue<float>();
        hMove.canceled += ctx => hInput = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(hInput * moveSpeed, rb.velocity.y, forwardSpeed);

        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
