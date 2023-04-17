using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [Tooltip("Player should always start on Lap 1 and the game ends after 3 is completed (which is when this number equals 4)")]
    public int currentLap = 1;

    [SerializeField] private float timer = 0;

    public TMP_Text timerText;

    public TMP_Text lapText;

    private float timerCap = 5*60;
    private float negationTimer = 0;

 
    void Start()
    {
        negationTimer = timerCap;
        currentLap = 1;

    }
 
    void Update()
    {
        TimerProcess();

        //if lap counter is greater than 3, goes to end of game
        if (currentLap >= 4)
        {
            RaceComplete();
        }

        lapText.text = "Lap " + currentLap;

    }

    /// <summary>
    /// Handles the calculation of the timer and the timer display.
    /// </summary>
    void TimerProcess()
    {
        timer += Time.deltaTime;
        timerCap -= Time.deltaTime;

        string t;

        t = "" + (timerCap / 60) + ":";
        t += (timerCap % 60);

        if (timerCap <= 0)
        {
            RaceComplete();
        }

        timerText.text += t;

    }

    /// <summary>
    /// Called when the race is completed.
    /// </summary>
    public void RaceComplete()
    {
        Debug.Log("RaceComplete called.");
        SceneManager.LoadScene("End");

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
    }
    
}
