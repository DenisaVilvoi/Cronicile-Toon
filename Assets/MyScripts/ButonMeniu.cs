using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonMeniu : MonoBehaviour
{
    public string sceneName;

    public void Meniu()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }
}
