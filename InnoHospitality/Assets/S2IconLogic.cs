using UnityEngine;

public class S2IconLogic : MonoBehaviour
{
    public GameObject Grab, PreClean1, PreClean2, Utensils, Greet, Guide, TakeOrder, ServeOrder, ServeBill, GetBill, PostClean1, PostClean2;

    void Start()
    {
        Grab.SetActive(false);
        PreClean1.SetActive(false);
        PreClean2.SetActive(false);
        Utensils.SetActive(false);
        Greet.SetActive(false);
        Guide.SetActive(false);
        TakeOrder.SetActive(false);
        ServeOrder.SetActive(false);
        ServeBill.SetActive(false); // <-- Added
        GetBill.SetActive(false);
        PostClean1.SetActive(false);
        PostClean2.SetActive(false);
    }

    public void GrabIcon()
    {
        Grab.SetActive(true);
    }

    public void PreClean1Icon()
    {
        PreClean1.SetActive(true);
    }

    public void PreClean2Icon()
    {
        PreClean2.SetActive(true);
    }

    public void UtensilsIcon()
    {
        Utensils.SetActive(true);
    }

    public void GreetIcon()
    {
        Greet.SetActive(true);
    }

    public void GuideIcon()
    {
        Guide.SetActive(true);
    }

    public void TakeOrderIcon()
    {
        TakeOrder.SetActive(true);
    }

    public void ServeOrderIcon()
    {
        ServeOrder.SetActive(true);
    }

    public void ServeBillIcon() 
    {
        ServeBill.SetActive(true);
    }

    public void GetBillIcon()
    {
        GetBill.SetActive(true);
    }

    public void PostClean1Icon()
    {
        PostClean1.SetActive(true);
    }

    public void PostClean2Icon()
    {
        PostClean2.SetActive(true);
    }
}
