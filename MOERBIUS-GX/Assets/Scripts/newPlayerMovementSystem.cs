using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class newPlayerMovementSystem : MonoBehaviour
{
    public Rigidbody rb;
    public float hInput;
    public float moveSpeed;
    public float forwardSpeed;

    public PlayerInput pI;
    public InputAction hMove;
    public InputAction restart;
    


    private float speedResetTimer = 3;

    private float increaseAmount;

    private float minSpeed = -20;
    private float maxSpeed = 50;

    private bool isBoosting;

    public float plusinMod;
    public float minusinMod;
    private bool SpeedPlusin;
    private bool SpeedMinusin;
    private float forwardSpeedInitial;

  


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


        restart = pI.currentActionMap.FindAction("Restart");

        restart.performed += ctx => SceneManager.LoadScene("Menu");

        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forwardSpeedInitial = forwardSpeed;
    }

    private void Update()
    {
        if (isBoosting == true)
        {
            speedResetTimer -= Time.deltaTime;

        }
        if (speedResetTimer <= 0)
        {
            isBoosting = false;
            speedResetTimer = 3;
        }

        
    }

    private void FixedUpdate()
    {
        if (SpeedPlusin == true)
        {
            //moveSpeed += plusinMod;
            forwardSpeed = forwardSpeedInitial + plusinMod;
            // print("Plus Boolin");
        }
        if (isBoosting == true)
        {
            forwardSpeed = forwardSpeedInitial + plusinMod;
        }
        if (SpeedMinusin == true)
        {
            //moveSpeed -= minusinMod;
            forwardSpeed = forwardSpeedInitial + minusinMod;
            //print("Minus Boolin");
        }
        if (SpeedPlusin == false && SpeedMinusin == false && isBoosting == false)
        {

            forwardSpeed = forwardSpeedInitial;

        }

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

    public void TempSpeedUp()
    {
        isBoosting = true;

        /*
        float increase = 20f;
        increaseAmount = increase;
        isBoosting = true;
        forwardSpeed += increase;
        StartCoroutine(ResetSpeed(increase));
        */

    }

    /*  IEnumerator ResetSpeed(float decrease)
      {

          yield return new WaitForSeconds(speedResetTimer);
          forwardSpeed -= decrease;
          isBoosting = false;
          yield return null;

 } */

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
        if (other.gameObject.tag == "SpeedPowerUp")
        {
            //other.gameObject.GetComponent<SpeedPowerUp>().CollisionBehavior;
        }

        if (other.gameObject.tag == "SpeedPlus")
        {
            SpeedPlusin = true;
            print("Plus Zone!");
        }

        if (other.gameObject.tag == "SpeedMinus")
        {
            SpeedMinusin = true;
            print("Minus Zone?!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "SpeedPlus")
        {
            SpeedPlusin = false;
            forwardSpeed = forwardSpeedInitial;
            print("Exited");
        }

        if (other.gameObject.tag == "SpeedMinus")
        {
            SpeedMinusin = false;
            forwardSpeed = forwardSpeedInitial;
            print("Exited");
        }
    }

}
