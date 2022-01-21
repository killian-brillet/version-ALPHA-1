using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batiment : MonoBehaviour
{
    public float price;
    public Ressources resources;
    public MeshRenderer MR;

    public float valueGold = 20f;

    public float valueKing = 50f;
    private bool SatifRoi = false;

    public float valuePeople = 70f;
    private bool SatifPeople = false;


    public float tempsActuel = 0;
    public float dureeTemps = 10f;
    public float tempsGain = 10f;

    public void Update()
    {
        GainGold();
        GainKing();
        GainPeople();
    }

    void GainGold()
    {
        if (tempsActuel < tempsGain)
        {
            tempsActuel += dureeTemps * Time.deltaTime;
        }

        if ((tempsActuel >= tempsGain))
        {
            tempsActuel = 0;
            if (resources.globalGold < resources.limiteGold)
            {
                resources.AddGold(valueGold);
            }
        }
    }
    void GainKing()
    {
        if (!SatifRoi)
        {
            resources.AddKing(valueKing);
            SatifRoi = true;
        }
    }

    void GainPeople()
    {
        if ((!SatifPeople))
        {
            resources.AddPeople(valuePeople);
            SatifPeople = true;
        }
    }
}
