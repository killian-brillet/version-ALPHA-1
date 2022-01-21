using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool isPaused = false;

    public void Start()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }

}
