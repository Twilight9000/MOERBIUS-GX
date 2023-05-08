using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public List<GameObject> allProgressPoints = new List<GameObject>();
    public GameObject checkpoint;
    public PlayerBehaviour pb;
    public GameController gc;
    public bool canLap;

    public string parentName;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindObjectOfType<GameController>();
        gc.GetComponent<GameController>();

        foreach (GameObject progressPoint in GameObject.FindGameObjectsWithTag("ProgressPoint"))
        {
            allProgressPoints.Add(progressPoint);
        }

        parentName = transform.parent.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //checkpoint = pb.activeCheckpoint;
            //CheckForProgress();
            if(parentName == "TopFinishLine")
            {
                gc.score += 3000;
                //gc.scoreText.text = "Score: " + gc.score.ToString();
            }
            else if (parentName == "MiddleFinishLine")
            {
                gc.score += 2000;
                //gc.scoreText.text = "Score: " + gc.score.ToString();
            }
            else if (parentName == "BottomFinishLine")
            {
                gc.score += 1000;
                //gc.scoreText.text = "Score: " + gc.score.ToString();
            }
        }
    }

    void CheckForProgress()
    {
        foreach (GameObject progressPoint in allProgressPoints)
        {
            if (progressPoint.GetComponent<CheckpointBehaviour>().isHit == false)
            {
                canLap = false;
                break;
            }
            else
            {
                canLap = true;
                continue;
            }
        }

        if (canLap == true)
        {
            gc.currentLap++;
            foreach (GameObject progressPoint in allProgressPoints)
            {
                progressPoint.GetComponent<CheckpointBehaviour>().isHit = false;
            }
        }
    }
}
