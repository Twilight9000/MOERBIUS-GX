using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTargetBehaviour : MonoBehaviour
{
    public float speed;

    public GameObject moveP1;
    public GameObject moveP2;

    public float timer;
    private float timerInitial;

    private bool moveTu1;

    // Start is called before the first frame update
    void Start()
    {
        timerInitial = timer;
    }

    // Update is called once per frame
    void Update()
    {

        if (moveTu1 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveP1.transform.position, speed * Time.deltaTime);
            print("slug");
        }
        if (moveTu1 == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveP2.transform.position, speed * Time.deltaTime);
            print("mlug");
        }



        timer -= Time.deltaTime;

        if (timer <= 0 && moveTu1 == true)
        {
            moveTu1 = false;
            timer = timerInitial;

        }
        if (timer <= 0 && moveTu1 == false)
        {
            moveTu1 = true;
            timer = timerInitial;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
