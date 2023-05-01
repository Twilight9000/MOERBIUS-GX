using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gc.score += 100;
            gc.scoreText.text = "Score: " + gc.score.ToString();
            Destroy(gameObject);
        }
    }
}
