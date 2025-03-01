using UnityEngine;

public class S2CanvasManager : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public ReceptionistAnimation receptionist;

    void Start()
    {
        WelcomeCanvasShow();
    }

    public void WelcomeCanvasShow()
    {
        ShowDialogue(WelcomeCanvas);
        receptionist.Talk();
    }

    public void WelcomeCanvasClose()
    {
        WelcomeCanvas.SetActive(false);
        receptionist.Idle();
    }

    private void ShowDialogue(GameObject dialogue)
    {
        WelcomeCanvas.SetActive(false);


        dialogue.SetActive(true);
    }
}