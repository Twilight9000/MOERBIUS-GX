using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    public float speed;
    private Vector3 moveDir;
    public Vector3 rotation;
    public Vector3 sillyRotation;

    public Rigidbody rb;
   
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0 ).normalized;
        float y = Input.GetAxisRaw("Horizontal");
        float x = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(-x, 0, y) * speed * Time.deltaTime);



    }


    private void FixedUpdate()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 20f);

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(-rotation * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {

            gameObject.transform.Rotate(rotation * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.R))
        {
            gameObject.transform.Rotate(-sillyRotation * Time.deltaTime);
           
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(sillyRotation * Time.deltaTime);
        }

        // rb.MovePosition(rb.position + transform.TransformDirection(moveDir) * speed * Time.deltaTime);
    }
}
