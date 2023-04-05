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


 
    void Start()
    {
        currentLap = 1;

    }
 
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

        string t;
        int min = (int)(timer / 60);

        int secs = (int)(timer % 60);

        t = "" + min + ":";
        if (secs < 10)
        {
            t += "0";

        }
        t += secs;
        timerText.text = t;

    }

    /// <summary>
    /// Called when the race is completed.
    /// </summary>
    void RaceComplete()
    {
        print("RaceComplete called.");
    }
    
}
