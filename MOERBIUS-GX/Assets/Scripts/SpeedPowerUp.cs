using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    private playerMovement pc;
    private float speedIncrease = 15f;
    public int DidThing;

    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<playerMovement>();
        DidThing = 0;

    }

    public void CollisionBehavior()
    {
        ++DidThing;
        pc.TempSpeedUp(speedIncrease);
        Destroy(gameObject);

    }



}
