using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class GameController : MonoBehaviour
{
    [Tooltip("Player should always start on Lap 1 and the game ends after 3 is completed (which is when this number equals 4)")]
    public int currentLap = 1;

    [SerializeField] public float timer = 0;

    public TMP_Text timerText;

    public TMP_Text lapText;

    public Text ammoText;

    private float timerCap = 5*60;
    private float negationTimer = 0;

    public GameObject pauseMenu, controlsMenu, player;

    public bool threeMinCheck; 

    void Start()
    {
        negationTimer = timerCap;
        currentLap = 1;
        player = GameObject.FindGameObjectWithTag("Player");

        ammoText.text = ("Ammo: " + player.GetComponent<ShootBehaviour>().bulletsAmount);

        pauseMenu.SetActive(false);pauseMenu.SetActive(false);
        controlsMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void TogglePause()
    {
        if (SceneManager.GetActiveScene().name == "Racetrack")
        {
            if (pauseMenu.activeInHierarchy == false && controlsMenu.activeInHierarchy == false)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else if (pauseMenu.activeInHierarchy == false && controlsMenu.activeInHierarchy == true)
            {
                controlsMenu.SetActive(false);
                Time.timeScale = 1;
                }
            else if (pauseMenu.activeInHierarchy == true)
            {
                pauseMenu.SetActive(false);
                controlsMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }        
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

        ammoText.text = ("Ammo: " + player.GetComponent<ShootBehaviour>().bulletsAmount);

    }

    /// <summary>
    /// Handles the calculation of the timer and the timer display.
    /// </summary>
    void TimerProcess()
    {
        timer += Time.deltaTime;
        negationTimer -= Time.deltaTime;

        string t;

        t = "" + (negationTimer / 60) + ":";
        t += (negationTimer % 60);

        if (negationTimer <= 0)
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
    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ControlsMenuOpen()
    {
        controlsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    
    public void ControlsMenuClose()
    {
        controlsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void Quit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}
