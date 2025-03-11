using UnityEngine;
using System.Collections;

public class S2CanvasManager : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, P1, D6, D7, D8, D9, D10, D11, D12, D13, C1;
    public GameObject P2, P3, P4, P5, P6, C2, C3, C4, C5;
    public ReceptionistAnimation receptionist;
    public GameObject utensils, gosign, customer1Mark, tableMark, tablet;


    void Start()
    {
        D1Show();
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
        P1.SetActive(false);
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
        customer1Mark.SetActive(false);
        C1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(false);
        P6.SetActive(false);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(false);
        C5.SetActive(false);
        tableMark.SetActive(false);
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


    public void D3Show()
    {
        ShowDialogue(D3);
        receptionist.Talk();
    }

    public void D3Close()
    {
        D3.SetActive(false);
        receptionist.Idle();
        utensils.SetActive(true);
        gosign.SetActive(true);
    }

    public void D4Show()
    {
        ShowDialogue(D4);
        receptionist.Talk();
    }

    public void D4Close()
    {
        D4.SetActive(false);
        receptionist.Idle();
        customer1Mark.SetActive(true);
    }

    public void D5Show()
    {
        ShowDialogue(P1);
        receptionist.Talk();
    }

    public void C1Show()
    {
        ShowDialogue(C1);
        StartCoroutine(ActivateP2WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP2WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        P2Show();
    }


    public void P2Show()
    {
        ShowDialogue(P2);
    }

    public void P3Show()
    {

        
        StartCoroutine(ActivateP3WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP3WithDelay()
    {
        yield return new WaitForSeconds(4); // Wait for 2 seconds
        ShowDialogue(P3);
    }

    public void C2Show()
    {
        ShowDialogue(C2);
        StartCoroutine(ActivateP4WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP4WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        P4Show();
    }

    public void P4Show()
    {
        ShowDialogue(P4);
    }

    public void C3Show()
    {
        ShowDialogue(C3);
        StartCoroutine(ActivateP5WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP5WithDelay()
    {
        yield return new WaitForSeconds(3); // Wait for 2 seconds
        P5Show();
    }

    public void P5Show()
    {
        ShowDialogue(P5);
    }

    public void C4Show()
    {
        ShowDialogue(C4);
        tablet.SetActive(true); 
    }

    public void D6Show()
    {
        ShowDialogue(D6);
        receptionist.Talk();
    }

    public void D6Close()
    {
        D6.SetActive(false);
        tableMark.SetActive(true);
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
        P1.SetActive(false);
        D6.SetActive(false);
        D7.SetActive(false);
        D8.SetActive(false);
        D9.SetActive(false);
        D10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        D13.SetActive(false);
        C1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(false);
        P6.SetActive(false);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(false);
        C5.SetActive(false);

        dialogue.SetActive(true);
    }
}