using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConstructorManager : MonoBehaviour
{
    public Ressources resources;
    private Batiment currentBatiment;
    public ButtonManager boutonmanager;
    public Button_constr Boutoncontruire;
    public gameManager Pause;

    public GameObject currentTooltip;
    public GameObject[] tooltipslist;

    public void SetCanConstruct(Batiment prefab)
    {
        if (currentBatiment != prefab)
        {
            boutonmanager.ActivateAllButton();
            currentBatiment = prefab;
        }
        else if (currentBatiment == prefab)
        {
            currentBatiment = null;
        }
    }

    public void UndoConstruct()
    {
        currentBatiment = null;
    }

    public void tooltips(GameObject imgtooltip)
    {
        if (currentTooltip != imgtooltip)
        {
            HideTooltip();
            currentTooltip = imgtooltip;
            currentTooltip.SetActive(true);
        }
        else if (currentTooltip == imgtooltip)
        {
            currentTooltip = null;
            HideTooltip();
        }
    }
    public void HideTooltip()
    {
        currentTooltip = null;
        foreach (var img in tooltipslist)
        {
            img.SetActive(false);
        }
    }

    public void BuildBatiment(EmplacementVide emplacement)
    {
        if (currentBatiment == null)
        {
            return;
        }
        if (emplacement.isBuilt)
        {
            return;
        }
        if (Pause.isPaused == true)
        {
            return;
        }


        if (currentBatiment.price <= resources.globalGold)
        {
            emplacement.isBuilt = true;
            var bat = Instantiate(currentBatiment.gameObject, emplacement.transform);
            emplacement.MR.enabled = false;
            bat.GetComponent<Batiment>().resources = resources;
            resources.AddGold(-currentBatiment.price);
            currentBatiment = null;
            currentTooltip = null;
            boutonmanager.ActivateAllButton();
            HideTooltip();
        }
        else if (currentBatiment.price > resources.globalGold)
        {
            return;
        }
    }
}
