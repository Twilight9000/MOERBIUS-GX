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

    // Start is called before the first frame update
    void Start()
    {
        task1.text = ("");
        task2.text = ("");
        task3.text = ("");

        task1Done = false;
        task2Done = false;
        task3Done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(task1Done == true || Input.GetKey(KeyCode.UpArrow))
        {
            task1.text = ("Move Forward: DONE");
        }
        else
        {
            task1.text = ("Move Forward: NOT DONE");
        }

        if (task2Done == true || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            task2.text = ("Rotate Around Track: DONE");
        }
        else
        {
            task2.text = ("Rotate Around Track: NOT DONE");
        }

        if (task3Done == true)
        {
            task3.text = ("Task 3: DONE");
        }
        else
        {
            task3.text = ("Task 3: NOT DONE");
        }
    }
}
