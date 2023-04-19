using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecklistBehaviour : MonoBehaviour
{
    public Text task1;
    public Text task2;
    public Text task3;

    public bool task1Done;
    public bool task2Done;
    public bool task3Done;

    public GameObject gc;
    public GameObject spu;
  

        // Start is called before the first frame update
    void Start()
    {
        task1.text = ("Fire Weapon: NOT DONE");
        task2.text = ("Complete Under 3 Minutes: IN PROGRESS");
        task3.text = ("Collect Speed Boost: NOT DONE");

        task1Done = false;
        task2Done = false;
        task3Done = false;

        gc = GameObject.Find("GameController");
        gc.GetComponent<GameController>();
        spu = GameObject.Find("SpeedIncreaseItem");
        spu.GetComponent<SpeedPowerUp>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            task1.text = ("Fire Weapon: DONE");
        }
     
        if (gc.GetComponent<GameController>().timer > 180)
        {
            task2.text = ("Complete Under 3 Minutes: FAILED");
        }

        if (spu.GetComponent<SpeedPowerUp>().DidThing > 0)
        {
            task3.text = ("Collect Speed Boost: DONE");
        }
    }
}
