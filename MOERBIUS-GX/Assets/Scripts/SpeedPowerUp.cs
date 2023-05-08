using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{

    private newPlayerMovementSystem npc;
   // private float speedIncrease = 15f;
    public int DidThing;

    // Start is called before the first frame update
    void Start()
    {
        npc = FindObjectOfType<newPlayerMovementSystem>();
        DidThing = 0;

    }

    /* public void CollisionBehavior()
     {
         ++DidThing;
         pc.TempSpeedUp(speedIncrease);
         Destroy(gameObject);

     } */

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            npc.TempSpeedUp();
            Destroy(gameObject);
        }
    }


}
