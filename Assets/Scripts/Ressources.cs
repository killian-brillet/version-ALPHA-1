using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ressources : MonoBehaviour
{
    public float globalGold = 200f;
    public float limiteGold = 2000f;

    public float globalKing = 50f;
    public float limiteKing = 100f;

    public float globalPeople = 50f;
    public float limitePeople = 100f;

    public Text goldText;
    public Text kingText;
    public Text peopleText;


    public void AddGold(float value)
    {

        globalGold = globalGold + value;
        if (globalGold > limiteGold)
        {
            globalGold = limiteGold;
        }
        else if(globalGold <= 0f)
        {
            globalGold = 0f;
        }
        goldText.text = globalGold.ToString("0000");

    }

    public void AddKing(float value)
    {

        globalKing += value;
        if (globalKing > limiteKing)
        {
            globalKing = limiteKing;
        }
        else if (globalKing < 0f)
        {
            globalKing = 0f;
        }
        kingText.text = globalKing.ToString("00") + "%";
    }
    public void AddPeople(float value)
    {

        globalPeople += value;
        if (globalPeople > limitePeople)
        {
            globalPeople = limitePeople;
        }
        else if (globalPeople < 0f)
        {
            globalPeople = 0f;
        }   
        peopleText.text = globalPeople.ToString("00") + "%";
    }

    public void EndGame()
    {
        if (globalGold >= 2000 && globalKing >= 70 && globalPeople >= 70)
        {
            SceneManager.LoadScene("EndGameGood");
        }
        else if (globalKing <= 20 && globalPeople <= 20)
        {
            SceneManager.LoadScene("EndGameBad");
        }
        else 
        {
            SceneManager.LoadScene("EndGameMoyen");
        }
    }
}
