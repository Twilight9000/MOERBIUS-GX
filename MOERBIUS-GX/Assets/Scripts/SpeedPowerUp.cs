using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    private playerMovement pc;
    private float speedIncrease = 15f;
    public bool DidThing;
    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<playerMovement>();
        DidThing = false;
    }

    public void CollisionBehavior()
    {
        pc.TempSpeedUp(speedIncrease);
        Destroy(gameObject);
        DidThing = true;
    }
}
