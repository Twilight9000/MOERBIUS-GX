using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject activeCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    }
}
