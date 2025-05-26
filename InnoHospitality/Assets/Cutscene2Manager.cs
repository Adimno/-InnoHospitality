using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cutscene2Manager : MonoBehaviour
{
    public GameObject Welcome, Instructions, Tools, Utensils, Chair, Order, Dirty, Customer, Done;
    public GameObject ToolsCircle, UtensilsCircle, ChairCircle, OrderCircle, DirtyCircle, CustomerCircle;

    public ReceptionistAnimation receptionist;

    void Start()
    {
        WelcomeShow();
        Welcome.SetActive(false);
        Instructions.SetActive(false);
        Tools.SetActive(false);
        Utensils.SetActive(false);
        Chair.SetActive(false);
        Order.SetActive(false);
        Dirty.SetActive(false);
        Customer.SetActive(false);
        Done.SetActive(false);

        ToolsCircle.SetActive(false);
        UtensilsCircle.SetActive(false);
        ChairCircle.SetActive(false);
        OrderCircle.SetActive(false);
        DirtyCircle.SetActive(false);
        CustomerCircle.SetActive(false);
    }

    public void WelcomeShow()
    {
        ShowDialogue(Welcome);
        receptionist.Talk();
    }


    public void InstructionsShow()
    {
        ShowDialogue(Instructions);
        receptionist.Talk();
    }

    public void InstructionsClose()
    {
        Instructions.SetActive(false);
        ToolsCircle.SetActive(true);
        receptionist.Idle();
    }

    public void ToolsShow()
    {
        ShowDialogue(Tools);
        receptionist.Talk();
    }

    public void ToolsClose()
    {
        Tools.SetActive(false);
        UtensilsCircle.SetActive(true);
        receptionist.Idle();
    }

    public void UtensilsShow()
    {
        ShowDialogue(Utensils);
        receptionist.Talk();
    }

    public void UtensilsClose()
    {
        Utensils.SetActive(false);
        ChairCircle.SetActive(true);
        receptionist.Idle();
    }

    public void ChairShow()
    {
        ShowDialogue(Chair);
        receptionist.Talk();
    }

    public void ChairClose()
    {
        Chair.SetActive(false);
        CustomerCircle.SetActive(true);
        receptionist.Idle();
    }

    public void CustomerShow()
    {
        ShowDialogue(Customer);
        receptionist.Talk();
    }

    public void CustomerClose()
    {
        Customer.SetActive(false);
        OrderCircle.SetActive(true);
        receptionist.Idle();
    }

    public void OrderShow()
    {
        ShowDialogue(Order);
        receptionist.Talk();
    }

    public void OrderClose()
    {
        Order.SetActive(false);
        DirtyCircle.SetActive(true);
        receptionist.Idle();
    }

    public void DirtyShow()
    {
        ShowDialogue(Dirty);
        receptionist.Talk();
    }

    public void DoneShow()
    {
        ShowDialogue(Done);
        receptionist.Talk();
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void TryAgain()
    {
        SceneManager.LoadScene("CutSceneS2");
    }

    private void ShowDialogue(GameObject dialogue)
    {
        Welcome.SetActive(false);
        Instructions.SetActive(false);
        Tools.SetActive(false);
        Utensils.SetActive(false);
        Chair.SetActive(false);
        Order.SetActive(false);
        Dirty.SetActive(false);
        Customer.SetActive(false);
        Done.SetActive(false);
    }

}

