using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S1CanvasManager : MonoBehaviour
{
    // Canvas
    public GameObject WelcomeCanvas;
    public GameObject TakeCardCanvas; 
    public GameObject OpenDoor;
    public GameObject KitchAreaCanvas;
    public GameObject GoKitchAreaCanvas;
    public GameObject KitchenPlayerCollider;
    
 // Assets
    public Button button;
    public GameObject CardReader; // card for reader
    public GameObject CardReaderParent; // card parent 
    public GameObject MarkKitchenCollider; // Kitchen mark 


    
    
    void Start()
    {
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);
        CardReaderParent.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
           MarkKitchenCollider.SetActive(false);
           KitchenPlayerCollider.SetActive(false); 
        // Disable button at start and start countdown
        button.interactable = false;
        StartCoroutine(EnableButtonAfterDelay(16f));
    }

    public void WelcomeCanvasLogic()
    {
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);
        CardReader.SetActive(false);
        KitchAreaCanvas.SetActive(false);
         TakeCardCanvas.SetActive(false);
    }

    public void TakeCardCanvasLogic()
    {
    
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(true);
        CardReader.SetActive(true);
        CardReaderParent.SetActive(true);
        KitchAreaCanvas.SetActive(false);
    }
    
       public void OpenDoorCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        OpenDoor.SetActive(true);
    }

       public void KitchAreaCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(true);
        StartCoroutine(GoKitchenArea(11f));
    }

       public void GoKitchAreaCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(true);
        MarkKitchenCollider.SetActive(true);
    }

    public void KitchenPlayerCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
         KitchenPlayerCollider.SetActive(true); 
    }




    private IEnumerator EnableButtonAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        button.interactable = true;
    }

      private IEnumerator GoKitchenArea(float delay)
    {
        yield return new WaitForSeconds(delay);
        GoKitchAreaCanvasLogic();
    }
}
