using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cutscene2Manager : MonoBehaviour
{
    public GameObject Welcome, Tools, Utensils, Chair, Order, Dirty, Customer, Done;
    public GameObject ToolsCircle, UtensilsCircle, ChairCircle, OrderCircle, DirtyCircle, CustomerCircle;

    public ReceptionistAnimation receptionist;

    void Start()
    {
        Welcome.SetActive(false);
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

    public void ToolsShow()
    {
        ShowDialogue(Tools);
        receptionist.Talk();
    }

    public void UtensilsShow()
    {
        ShowDialogue(Utensils);
        receptionist.Talk();
    }

    public void ChairShow()
    {
        ShowDialogue(Chair);
        receptionist.Talk();
    }

    public void CustomerShow()
    {
        ShowDialogue(Customer);
        receptionist.Talk();
    }

    public void OrderShow()
    {
        ShowDialogue(Order);
        receptionist.Talk();
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
        Tools.SetActive(false);
        Utensils.SetActive(false);
        Chair.SetActive(false);
        Order.SetActive(false);
        Dirty.SetActive(false);
        Customer.SetActive(false);
        Done.SetActive(false);
    }

}

