using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S1CanvasManager : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject TakeCardCanvas; 
    public Button button;
    public GameObject CardReader;
    
    void Start()
    {
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);

        // Disable button at start and start countdown
        button.interactable = false;
        StartCoroutine(EnableButtonAfterDelay(16f));
    }

    public void WelcomeCanvasLogic()
    {
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);
        CardReader.SetActive(false);
    }

    public void TakeCardCanvasLogic()
    {
    
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(true);
        CardReader.SetActive(true);
    }

    private IEnumerator EnableButtonAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        button.interactable = true;
    }
}
