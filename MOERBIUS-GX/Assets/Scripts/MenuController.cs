using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    string one = "MOERBIUS-GX";
    string two = "MOEBIUS-GX";
    string three = "MOERBUS-GX";

    public TMP_Text title;

    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = Random.Range(1, 4);

        switch (a)
        {
            case 1:
                title.text = one;
                break;
            case 2:
                title.text = two;
                break;
            case 3:
                title.text = three;
                break;
            default:
                Debug.LogError("problem with random number :(");
                break;
        }
        
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("NEW TRACK");
    }
}
