using UnityEngine;

public class S2CanvasManager : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13;
    public ReceptionistAnimation receptionist;
    public GameObject utensils, gosign;


    void Start()
    {
        D1Show();
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D5.SetActive(false);
        D6.SetActive(false);
        D7.SetActive(false);
        D8.SetActive(false);
        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        D13.SetActive(false);
        utensils.SetActive(false);
        gosign.SetActive(false);
    }

    public void D1Show()
    {
        ShowDialogue(D1);
        receptionist.Talk();
    }

    public void D2Show()
    {
        ShowDialogue(D2);
        receptionist.Talk();
    }

    public void D2Close()
    {
        D2.SetActive(false);
        receptionist.Idle();
        utensils.SetActive(true);
        gosign.SetActive(true);
    }

    public void D3Show()
    {
        ShowDialogue(D3);
        receptionist.Talk();
    }

    public void D4Show()
    {
        ShowDialogue(D4);
        receptionist.Talk();
    }

    public void D5Show()
    {
        ShowDialogue(D5);
        receptionist.Talk();
    }

    public void D6Show()
    {
        ShowDialogue(D6);
        receptionist.Talk();
    }

    public void D7Show()
    {
        ShowDialogue(D7);
        receptionist.Talk();
    }

    public void D8Show()
    {
        ShowDialogue(D8);
        receptionist.Talk();
    }

    public void D9Show()
    {
        ShowDialogue(D9);
        receptionist.Talk();
    }

    public void D10Show()
    {
        ShowDialogue(D10);
        receptionist.Talk();
    }

    public void D11Show()
    {
        ShowDialogue(D11);
        receptionist.Talk();
    }

    public void D12Show()
    {
        ShowDialogue(D12);
        receptionist.Talk();
    }

    public void D13Show()
    {
        ShowDialogue(D13);
        receptionist.Talk();
    }

    

    private void ShowDialogue(GameObject dialogue)
    {
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        D5.SetActive(false);
        D6.SetActive(false);
        D7.SetActive(false);
        D8.SetActive(false);
        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        D13.SetActive(false);

        dialogue.SetActive(true);
    }
}