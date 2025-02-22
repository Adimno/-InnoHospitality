using UnityEngine;

public class S1CanvasManager : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject TakeCardCanvas; 
    
    void Start()
    {
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);
    }

    public void WelcomeCanvasLogic()
    {
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);
    }

    public void TakeCardCanvasLogic()
    {
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(true);
    }
}
