using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    private ShootBehaviour sb;
    public int ammoIncreaseAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        sb = FindObjectOfType<ShootBehaviour>(); 
    }


    public void AddAmmo()
    {
        sb.bulletsAmount += ammoIncreaseAmount;
        Destroy(gameObject);

    }

}
