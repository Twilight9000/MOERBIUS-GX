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

    public PlayerInput pI;
    public InputAction hMove;


    private float speedResetTimer = 5;

    private float increaseAmount;

    public float minSpeed;
    public float maxSpeed;

    private bool isBoosting;


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

        if (isBoosting!)
        {
            forwardSpeed = Mathf.Clamp(forwardSpeed, minSpeed, maxSpeed);
        }
        else
        {
            forwardSpeed = Mathf.Clamp(forwardSpeed, minSpeed, maxSpeed + increaseAmount);
        }

    }

    public void TempSpeedUp(float increase)
    {
        increaseAmount = increase;
        isBoosting = true;
        forwardSpeed += increase;
        StartCoroutine(ResetSpeed(increase));

    }

    IEnumerator ResetSpeed(float decrease)
    {
        yield return new WaitForSeconds(speedResetTimer);
        forwardSpeed -= decrease;
        isBoosting = false;
        yield return null;

    }

}
