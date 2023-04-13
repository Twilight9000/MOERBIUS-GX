using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameController : MonoBehaviour
{
    [Tooltip("Player should always start on Lap 1 and the game ends after 3 is completed (which is when this number equals 4)")]
    public int currentLap = 1;

    [SerializeField] private float timer = 0;

    public TMP_Text timerText;

    public TMP_Text lapText;

    public GameObject pauseMenu;

    public PlayerInput pI;

    public InputAction pauseToggle;

    private void Awake()
    {

        pI.currentActionMap.Enable();

        pauseToggle = pI.currentActionMap.FindAction("PauseToggle");
    }

    void Start()
    {
        currentLap = 1;

        pauseMenu.SetActive(false);

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
