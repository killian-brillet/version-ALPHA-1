using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Scene scene;

    private void Start()
    {

    }

    public void LoadLevel(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
