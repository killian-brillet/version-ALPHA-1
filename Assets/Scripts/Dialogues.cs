using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogues : MonoBehaviour
{
    public GameObject imgdialogue;
    public GameObject imgdialogue2;
    public GameObject imgdialogue3;
    public GameObject imgdialogue4;
    public GameObject imgdialogue5;
    public GameObject imgdialogue6;

    private bool event1ready = false;
    private bool event2ready = false;
    private bool event3ready = false;
    private bool event4ready = false;
    private bool event5ready = false;
    private bool event6ready = false;

    public GameObject notif;
    public Button button_dialogue;
    public TimerBar timer;

    public gameManager Pause;

    private int etapedialogue = 0;
    private bool etatdialogue;

    void Start()
    {
        etatdialogue = false;
    }

    public void ClicDialogue()
    {
        if (etatdialogue == true)
        {
            imgdialogue.SetActive(false);
            imgdialogue2.SetActive(false);
            imgdialogue3.SetActive(false);
            imgdialogue4.SetActive(false);
            imgdialogue5.SetActive(false);
            imgdialogue6.SetActive(false);
            Pause.ResumeGame();
            etatdialogue = false;
            Debug.Log(etatdialogue);
        }
        else if (etatdialogue == false)
        {
            if (etapedialogue == 0 && event1ready == true)
            {
                imgdialogue.SetActive(true);
                etatdialogue = true;
                Pause.PauseGame();
            }
            else if (etapedialogue == 1 && event2ready == true)
            {
                imgdialogue2.SetActive(true);
                etatdialogue = true;
                Pause.PauseGame();
            }
            else if (etapedialogue == 2 && event3ready == true)
            {
                imgdialogue3.SetActive(true);
                etatdialogue = true;
                Pause.PauseGame();
            }
            else if (etapedialogue == 3 && event4ready == true)
            {
                imgdialogue4.SetActive(true);
                etatdialogue = true;
                Pause.PauseGame();
            }
            else if (etapedialogue == 4 && event5ready == true)
            {
                imgdialogue5.SetActive(true);
                etatdialogue = true;
                Pause.PauseGame();
            }
            else if (etapedialogue == 5 && event6ready == true)
            {
                imgdialogue6.SetActive(true);
                etatdialogue = true;
                Pause.PauseGame();
            }
        }
    }

    public void FinDialogue()
    {
        notif.SetActive(false);
        etapedialogue += 1;
        etatdialogue = false;
        Debug.Log(etapedialogue);
        Pause.ResumeGame();
    }
    public void Event1()
    {
        event1ready = true;
        notif.SetActive(true);
    }
    public void Event2()
    {
        event2ready = true;
        notif.SetActive(true);
    }
    public void Event3()
    {
        event3ready = true;
        notif.SetActive(true);
    }
    public void Event4()
    {
        event4ready = true;
        notif.SetActive(true);
    }
    public void Event5()
    {
        event5ready = true;
        notif.SetActive(true);
    }
    public void Event6()
    {
        event6ready = true;
        notif.SetActive(true);
    }
}
