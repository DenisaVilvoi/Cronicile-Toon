using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour
{
    public GameObject pauseMeniuUI;

    public void Continue()
    {      
        pauseMeniuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
