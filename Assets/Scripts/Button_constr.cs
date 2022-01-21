using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_constr : MonoBehaviour
{
    public Button button_const;
    public Button button_bat1;
    public Button button_bat2;
    public Button button_bat3;
    public Button button_bat4;
    public Button button_bat5;
    public Button button_bat6;
    public Image image;
    private bool etatbutton;
    private ConstructorManager manager;

    void Start()
    {
        etatbutton = false;
    }

    public void ClicBat()
    {
        if (etatbutton == false)
        {
            button_bat1.gameObject.SetActive(true);
            button_bat2.gameObject.SetActive(true);
            button_bat3.gameObject.SetActive(true);
            button_bat4.gameObject.SetActive(true);
            button_bat5.gameObject.SetActive(true);
            button_bat6.gameObject.SetActive(true);
            image.gameObject.SetActive(true);
            etatbutton = true;
        }
        else if (etatbutton == true)
        {
            button_bat1.gameObject.SetActive(false);
            button_bat2.gameObject.SetActive(false);
            button_bat3.gameObject.SetActive(false);
            button_bat4.gameObject.SetActive(false);
            button_bat5.gameObject.SetActive(false);
            button_bat6.gameObject.SetActive(false);
            image.gameObject.SetActive(false);
            etatbutton = false;
        }
    }
}
