using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [Tooltip("Player should always start on Lap 1 and the game ends after 3 is completed (which is when this number equals 4)")]
    public int currentLap = 1;

    [SerializeField] private float timer = 0;

    public TMP_Text timerText;


    // Start is called before the first frame update
    void Start()
    {
        currentLap = 1;

    }

    // Update is called once per frame
    void Update()
    {
        TimerProcess();

        if (currentLap >= 4)
        {
            RaceComplete();
        }

    }

    /// <summary>
    /// Handles the calculation of the timer and the timer display.
    /// </summary>
    void TimerProcess()
    {
        timer += Time.deltaTime;

        string t = 



    }

    void RaceComplete()
    {
        print("RaceComplete called.");
    }
    
}
