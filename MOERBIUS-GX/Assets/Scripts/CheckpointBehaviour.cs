using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : MonoBehaviour
{
    public bool isHit = false;
    public GameObject checkpoint;
    PlayerBehaviour pb;

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
        if (other.gameObject.tag == "Player")
        {
            isHit = true;
            checkpoint = pb.activeCheckpoint;
        }
    }
}
