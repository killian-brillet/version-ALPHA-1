using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public Scene scene;

    public void Quit(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
