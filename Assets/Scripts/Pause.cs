using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Button bouton_resume;
    public Button bouton_quit;
    public GameObject UIingame;
    public GameObject Menupause;
    private void Start()
    {
        
    }

    private void Update()
    {
        bouton_resume.onClick.AddListener(SortiePause);
        bouton_quit.onClick.AddListener(FinJeu);
    }

    public void SortiePause()
    {
        UIingame.SetActive(true);
        Menupause.SetActive(false);
    }
    public void FinJeu()
    {

    }
}
