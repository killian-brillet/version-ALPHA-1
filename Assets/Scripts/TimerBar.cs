using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerBar : MonoBehaviour
{
    public Temps temps;
    public Image barImage;
    private void Awake()
    {
        barImage = transform.Find("Bar").GetComponent<Image>();
    }

    private void Update()
    {
        temps.Update();

        barImage.fillAmount = temps.GetTimeNormalized();

    }

    public void EndEvent1()
    {
        temps.EndEvent1();
    }
    public void EndEvent2()
    {
        temps.EndEvent2();
    }
    public void EndEvent3()
    {
        temps.EndEvent3();
    }
    public void EndEvent4()
    {
        temps.EndEvent4();
    }
    public void EndEven5()
    {
        temps.EndEvent5();
    }
    public void EndEven6()
    {
        temps.EndEvent6();
    }
}

[System.Serializable]
public class Temps
{
    public const int Temps_Max = 100;
    public float tempsActuel;
    private float dureeTemps;
    public Dialogues dialoguemanager;
    public Ressources ressourcesfin;

    private bool event1done = false;
    private bool event2done = false;
    private bool event3done = false;
    private bool event4done = false;
    private bool event5done = false;
    private bool event6done = false;

    public Temps()
    {
        tempsActuel = 0;
        dureeTemps = 0.25f;
    }

    public void Update()    
    {
        tempsActuel += dureeTemps * Time.deltaTime;

        if (tempsActuel >= 10 && event1done == false)
        {
            dialoguemanager.Event1();
        }
        if (tempsActuel >= 30 && event2done == false)
        {
            dialoguemanager.Event2();
        }
        if (tempsActuel >= 50 && event3done == false)
        {
            dialoguemanager.Event3();
        }
        if (tempsActuel >= 70 && event4done == false)
        {
            dialoguemanager.Event4();
        }
        if (tempsActuel >= 80 && event5done == false)
        {
            dialoguemanager.Event5();
        }
        if (tempsActuel >= 90 && event6done == false)
        {
            dialoguemanager.Event6();
        }
        if (tempsActuel >= 100)
        {
            ressourcesfin.EndGame();
        }
    }
    
    public float GetTimeNormalized()
    {
        return tempsActuel / Temps_Max;
    }

    public void EndEvent1()
    {
        event1done = true;
    }
    public void EndEvent2()
    {
        event2done = true;
    }
    public void EndEvent3()
    {
        event3done = true;
    }
    public void EndEvent4()
    {
        event4done = true;
    }
    public void EndEvent5()
    {
        event5done = true;
    }
    public void EndEvent6()
    {
        event6done = true;
    }
}
