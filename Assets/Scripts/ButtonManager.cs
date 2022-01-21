using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button[] Bouton1;
    public bool etatbouton;

    public void Start()
    {

    }

    public void ActivateAllButton()
    {
        foreach (var but in Bouton1)
        {
            but.interactable = true;
        }
    }

    public void ChangeButtonStatus(Button Bouton)
    {
        if (etatbouton == false)
        {
            etatbouton = true;
        }
        else if (etatbouton == true)
        {
            etatbouton = false;
        }
    }
}
