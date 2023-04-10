using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public List<GameObject> allProgressPoints = new List<GameObject>();
    public GameObject checkpoint;
    PlayerBehaviour pb;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject progressPoint in GameObject.FindGameObjectsWithTag("ProgressPoint"))
        {
            allProgressPoints.Add(progressPoint);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            checkpoint = pb.activeCheckpoint;
            CheckForProgress();
        }
    }

    void CheckForProgress()
    {
        foreach (GameObject progressPoint in allProgressPoints)
        {
            if (progressPoint == false)
            {
                break;
            }
            else
            {
                //lapComplete
            }
        }
    }
}
