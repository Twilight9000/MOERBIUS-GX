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

    private float minSpeed = -20;
    private float maxSpeed = 25;

    private bool isBoosting;
   
    /// <summary>
    /// checkpoint detection
    /// </summary>
    public GameObject activeCheckpoint;

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

    /// <summary>
    /// This is the script from PlayerBehaviour that handled checkpoints and ammo pickups.
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            gameObject.transform.position = activeCheckpoint.transform.position;
        }
        if (other.gameObject.tag == "AmmoPickup")
        {
            other.gameObject.GetComponent<AmmoPickup>().AddAmmo();
        }
       //idk why this doesn't work -Jaxson
        if(other.gameObject.tag == "SpeedPowerUp")
        {
            //other.gameObject.GetComponent<SpeedPowerUp>().CollisionBehavior;
        }
    }

}
