using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float rotatingXSpeed;
    public float hInput;
    public float vInput;
    public GameObject pivotPointObj;
    public float playerHeight;
    public float gravityStrength = 5;
    public Rigidbody rb;

    public Vector3 jumpDirection;
    public float jumpForce;

    public bool isGrounded;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    public CinemachineDollyCart dollyTrack;
    public float forwardSpeed;
    public int direction;
    public bool isOnGas;
    public bool isOnReverse;

    public float minSpeed;
    public float maxSpeed;
    public float accelAndDecelValue;

    public PlayerInput pI;

    public InputAction hMove;
    public InputAction vMove;
    public InputAction accelerate;
    public InputAction reverse;
    public InputAction restart;
    public InputAction quit;

    private void Awake()
    {
        pI = GetComponent<PlayerInput>();

        pI.currentActionMap.Enable();

        hMove = pI.currentActionMap.FindAction("hMove");
        vMove = pI.currentActionMap.FindAction("vMove");
        accelerate = pI.currentActionMap.FindAction("Accelerate");
        reverse = pI.currentActionMap.FindAction("Reverse");
        restart = pI.currentActionMap.FindAction("Restart");
        quit = pI.currentActionMap.FindAction("Quit");

        hMove.performed += ctx => hInput = ctx.ReadValue<float>();
        hMove.canceled += ctx => hInput = 0;

        vMove.performed += ctx => vInput = ctx.ReadValue<float>();
        vMove.canceled += ctx => vInput = 0;

        accelerate.performed += ctx => isOnGas = true;
        accelerate.canceled += ctx => isOnGas = false;

        reverse.performed += ctx => isOnReverse = true;
        reverse.canceled += ctx => isOnReverse = false;

        restart.performed += ctx => SceneManager.LoadScene("Racetrack");

        quit.performed += ctx => Application.Quit();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isOnGas)
        {
            direction = 1;
        } else if (isOnReverse)
        {
            direction = -1;
        }

        if (isOnGas || isOnReverse)
        {
            forwardSpeed += accelAndDecelValue;
        }
        else
        {
            forwardSpeed -= accelAndDecelValue;
        }

        forwardSpeed = Mathf.Clamp(forwardSpeed, minSpeed, maxSpeed);
        setDollySpeed(direction * forwardSpeed);

        //rb.useGravity = !isGrounded;

        //gameObject.transform.RotateAround(pivotPointObj.transform.position, new Vector3(0, 0, 1), hInput * rotatingXSpeed);

        /*
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, playerHeight))
        {
            Vector3 surfaceNormal = hit.normal;
            transform.position += surfaceNormal * (playerHeight / 2.0f);
        }

        Debug.DrawRay(transform.position, -transform.up * playerHeight, Color.red);
        */

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = jumpDirection.normalized * jumpForce;
        }
        */
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector3 collisionNormal = collision.contacts[0].normal;

            transform.rotation = Quaternion.LookRotation(transform.position - collision.transform.position, collisionNormal);

            transform.position += collisionNormal * (playerHeight / 2.0f);

            Physics.gravity = -collisionNormal * gravityStrength;
            jumpDirection = collisionNormal;
        }
    }

    public void setDollySpeed(float speed)
    {
        dollyTrack.m_Speed = speed;
    }
}
