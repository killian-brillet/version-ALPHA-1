using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesPause : MonoBehaviour
{
    public GameObject pause;
    public GameObject UIingame;
    public UnityEngine.UI.Button bouton_pause; 

    void Start()
    {
        pause.SetActive(false);
    }

    void Update()
    {

    }

    public void menuPause()
    {
        UIingame.SetActive(false);
        pause.SetActive(true);
    }
}
