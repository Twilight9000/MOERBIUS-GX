using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

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

    public PlayerInput pI;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pI = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

        setDollySpeed(vInput * forwardSpeed);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        //rb.useGravity = !isGrounded;

        gameObject.transform.RotateAround(pivotPointObj.transform.position, new Vector3(0, 0, 1), hInput * rotatingXSpeed);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, playerHeight))
        {
            Vector3 surfaceNormal = hit.normal;
            transform.position += surfaceNormal * (playerHeight / 2.0f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = jumpDirection.normalized * jumpForce;
        }
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
