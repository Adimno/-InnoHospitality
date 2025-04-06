using UnityEngine;
using System.Collections;

public class S2CanvasManager : MonoBehaviour
{
    public GameObject D1, D2, D3, D4, P1, D6, D7, D8, C1;
    public GameObject P2, P3, P4, P5, P6, C2, C3, C4, C5;
    public ReceptionistAnimation receptionist;
    public GameObject utensils, gosign, customer1Mark, tableMark, tablet;
    public GameObject WrongOrder, AskAgain, Order1;
    public GameObject WrongOrder2, AskAgain2;
    public S2IconLogic icon;

    // customer2
    public GameObject utensils2, customer2Mark, tableMark2, Order2, gosign2;
    public GameObject D9, C6, P7, P8,P9, D10, C7, P10, C8, P11, C9, C10, D11, D12;

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
        WrongOrder.SetActive(false);
        AskAgain.SetActive(false);
        Order1.SetActive(false);
        WrongOrder2.SetActive(false);
        AskAgain2.SetActive(false);
        Order2.SetActive(false);

        utensils2.SetActive(false);
        customer2Mark.SetActive(false);
        tableMark2.SetActive(false);
        Order2.SetActive(false);
        D9.SetActive(false);
        C6.SetActive(false);
        P7.SetActive(false);
        P8.SetActive(false);
        D10.SetActive(false);

        C7.SetActive(false);
        P9.SetActive(false);
        P10.SetActive(false);
        C8.SetActive(false);
        P11.SetActive(false);
        C9.SetActive(false);
        C10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
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
        icon.ShowGreet1();
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

    public void C5Show()
    {
        icon.ShowGreet2();
        ShowDialogue(C5);
        StartCoroutine(ActivateD7WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateD7WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        D7Show();
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

    public void D7Close()
    {
        D7.SetActive(false);
        Order1.SetActive(true);

    }

    public void D8Close() //lastorder
    {
        D8.SetActive(false);
        utensils2.SetActive(true);
        gosign2.SetActive(true);
    }

    public void AskAgainShow()
    {
        ShowDialogue(AskAgain);
    }

    public void D9Close()
    {
        D9.SetActive(false);
        receptionist.Idle();
        customer2Mark.SetActive(true);
    }

    public void C6Show()
    {
        ShowDialogue(C6);
        StartCoroutine(ActivateP8WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP8WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        P8Show();
    }

    public void P8Show()
    {
        ShowDialogue(P8);
    }

    public void D10Show()
    {
        ShowDialogue(D10);
        receptionist.Talk();
    }

    public void D10Close()
    {
        D10.SetActive(false);
        receptionist.Idle();
        tableMark2.SetActive(true);

    }


    public void C7Show()
    {
        ShowDialogue(C7);
        StartCoroutine(ActivateP10WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP10WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        P10Show();
    }

    public void P10Show()
    {
        ShowDialogue(P10);
    }

    public void C8Show()
    {
        ShowDialogue(C8);
        StartCoroutine(ActivateP11WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateP11WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        P11Show();
    }

    public void P11Show()
    {
        ShowDialogue(P11);
    }

    public void C9Show()
    {
        ShowDialogue(C9);
        tablet.SetActive(true);
    }

    public void AskOrderAgain2Show()
    {
        ShowDialogue(AskAgain2);
    }

    public void C10Show()
    {
        ShowDialogue(C10);
        StartCoroutine(ActivateD11WithDelay()); // Start the coroutine
    }

    private IEnumerator ActivateD11WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        D11Show();
    }

    public void D11Show()
    {
        ShowDialogue(D11);
    }

    public void D11Close()
    {
        D11.SetActive(false);
        Order2.SetActive(true);
    }

    public void D12Close()
    {
        D12.SetActive(false);
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
        WrongOrder.SetActive(false);
        AskAgain.SetActive(false);
        D9.SetActive(false);
        C6.SetActive(false);
        P7.SetActive(false);
        P8.SetActive(false);
        D10.SetActive(false);
        C7.SetActive(false);
        P9.SetActive(false);
        P10.SetActive(false);
        C8.SetActive(false);
        P11.SetActive(false);
        C9.SetActive(false);
        WrongOrder2.SetActive(false);
        AskAgain2.SetActive(false);
        Order2.SetActive(false);
        C10.SetActive(false);
        D11.SetActive(false);
        D12.SetActive(false);
        dialogue.SetActive(true);
    }
}