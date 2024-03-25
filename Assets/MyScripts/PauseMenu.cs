using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMeniuUI;
    public GameObject canvasUI;


    void Start()
    {
        canvasUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            canvasUI.SetActive(true);

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {

                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMeniuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }   

    public void Pause()
    {
        pauseMeniuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }


}








