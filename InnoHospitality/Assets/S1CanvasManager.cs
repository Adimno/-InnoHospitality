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
    public GameObject LookLivingRoom;
    public GameObject GoLivingRoom; 
    public GameObject LivingRoomCanvas;
    public GameObject LookLeftLivingRoomCanvas;
    public GameObject GoTrashbinCanvas;
    public GameObject TrashbinCanvas;
    public GameObject BioMeansCanvas;
    public GameObject EnvironmentCanvas;
    public GameObject ChecklistTrashBinCanvas;
    public GameObject CongratsTrashBinCanvas;
    public GameObject GoBedAreaCanvas;
    public GameObject OpenBedDoorCanvas;
    public GameObject BedroomCanvas;
    public GameObject GoBedroomMarkedAreaCanvas;
    public GameObject StartSetUpBedAreaCanvas;
    public GameObject AppliancesLookCanvas;
  

    
 // Assets
    public Button button;
    public GameObject CardReader; // card for reader
    public GameObject CardReaderParent; // card parent 
    public GameObject MarkKitchenCollider; // Kitchen mark 
    public GameObject MarkLivingRoomCollider; // Kitchen mark 
    public GameObject MarkTrashCollider; // Kitchen mark 
    public GameObject MarkBedDoorCollider; // Kitchen mark 
    public GameObject MarkBedRoomCollider; // Kitchen mark 
    public GameObject PillowGuide;

    public GameObject[] TrashbinChecklist;
     public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] XRGrabInteractableGrabs;


    
    
    void Start()
    {
        // Canvas
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(true);
        TakeCardCanvas.SetActive(false);
        CardReaderParent.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        CongratsTrashBinCanvas.SetActive(false);
         GoBedAreaCanvas.SetActive(false);
         OpenBedDoorCanvas.SetActive(false);
         BedroomCanvas.SetActive(false);
        GoBedroomMarkedAreaCanvas.SetActive(false);
        StartSetUpBedAreaCanvas.SetActive(false);
        AppliancesLookCanvas.SetActive(false);
        
         
        
        // Assets
        MarkKitchenCollider.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        MarkTrashCollider.SetActive(false);
        MarkBedDoorCollider.SetActive(false);
        MarkBedRoomCollider.SetActive(false);
     
        
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
        foreach (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab in XRGrabInteractableGrabs)
    {
        if (grab != null)
        {
            grab.enabled = false; // Completely disables grabbing
            // Alternative: grab.allowSelect = false; // Only prevents grabbing without disabling the whole component
        }
    }

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
         StartCoroutine(LookLivingRoomArea(8f));
    }

        public void LookLivingRoomCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(true);
        StartCoroutine(GoLivingRoomArea(5f));
    }

     public void GoLivingRoomCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(true);
        MarkLivingRoomCollider.SetActive(true);
    }

    
     public void LivingRoomCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(true);
         StartCoroutine(LookLeftLivingRoomArea(4.5f));
    }

       public void LookLeftLivingRoomCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(true);
        StartCoroutine(GoTrashbinRoomArea(9.5f));
    }

         public void GoTrashbinCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(true);
        MarkTrashCollider.SetActive(true);
     
    }

    
         public void TrashbinCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(true);
         StartCoroutine(BioMeansRoomArea(5.5f));
     
    }

         public void BioMeansCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(true);
        StartCoroutine(EnvironmentRoomArea(9.5f));
     
    }

    
         public void EnvironmentCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(true);
        StartCoroutine(ChecklistTrashbinRoomArea(4.5f));
     
    }

          public void ChecklistTrashBinCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(true);

        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(true);
         }

           foreach (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab in XRGrabInteractableGrabs)
    {
        if (grab != null)
        {
            grab.enabled = true;
            // Alternative: grab.allowSelect = true;
        }
    }
     
    }

    
     public void CongratsTrashCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(true);
          StartCoroutine(GoBedRoomArea(6.5f));

     
    }

    
     public void GoBedAreaCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(false);
        GoBedAreaCanvas.SetActive(true);
        MarkBedDoorCollider.SetActive(true);

     
    }

        public void OpenBedDoorCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(false);
        GoBedAreaCanvas.SetActive(false);
         OpenBedDoorCanvas.SetActive(true);

     
    }

    
        public void BedroomCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(false);
        GoBedAreaCanvas.SetActive(false);
         OpenBedDoorCanvas.SetActive(false);
         BedroomCanvas.SetActive(true);
             StartCoroutine(MarkedPillowAreaCollider(12.5f));
     
    }

      public void GoBedroomMarkedAreaCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(false);
        GoBedAreaCanvas.SetActive(false);
         OpenBedDoorCanvas.SetActive(false);
         BedroomCanvas.SetActive(false);
        GoBedroomMarkedAreaCanvas.SetActive(true);
         StartCoroutine(StartSetUpBedGuide(6f));
     
    }

      public void StartSetUpBedAreaCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(false);
        GoBedAreaCanvas.SetActive(false);
         OpenBedDoorCanvas.SetActive(false);
         BedroomCanvas.SetActive(false);
        GoBedroomMarkedAreaCanvas.SetActive(false);
        StartSetUpBedAreaCanvas.SetActive(true);
           PillowGuide.SetActive(false);
        
     
    }

         public void AppliancesLookCanvasLogic()
    {
        CardReaderParent.SetActive(false);
        CardReader.SetActive(false);
        WelcomeCanvas.SetActive(false);
        TakeCardCanvas.SetActive(false);
        OpenDoor.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        GoKitchAreaCanvas.SetActive(false);
        MarkKitchenCollider.SetActive(false);
        KitchenPlayerCollider.SetActive(false); 
        LookLivingRoom.SetActive(false);
        GoLivingRoom.SetActive(false);
        MarkLivingRoomCollider.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        LookLeftLivingRoomCanvas.SetActive(false);
        GoTrashbinCanvas.SetActive(false);
        MarkTrashCollider.SetActive(false);
        TrashbinCanvas.SetActive(false);
        BioMeansCanvas.SetActive(false);
        EnvironmentCanvas.SetActive(false);
        ChecklistTrashBinCanvas.SetActive(false);
        foreach (GameObject trashbin in TrashbinChecklist) 
         {
        trashbin.SetActive(false);
         }
         
         CongratsTrashBinCanvas.SetActive(false);
        GoBedAreaCanvas.SetActive(false);
         OpenBedDoorCanvas.SetActive(false);
         BedroomCanvas.SetActive(false);
        GoBedroomMarkedAreaCanvas.SetActive(false);
        StartSetUpBedAreaCanvas.SetActive(false);
           PillowGuide.SetActive(false);
           AppliancesLookCanvas.SetActive(true);
        
     
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

        private IEnumerator LookLivingRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
        LookLivingRoomCanvasLogic();
    }

       private IEnumerator GoLivingRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
        GoLivingRoomCanvasLogic();
    }

        private IEnumerator LookLeftLivingRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
        LookLeftLivingRoomCanvasLogic();
    }

        private IEnumerator GoTrashbinRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
       GoTrashbinCanvasLogic();
    }

    
        private IEnumerator BioMeansRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
       BioMeansCanvasLogic();
    }

      private IEnumerator EnvironmentRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
       EnvironmentCanvasLogic();
    }

        private IEnumerator ChecklistTrashbinRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
        ChecklistTrashBinCanvasLogic();
    }

           private IEnumerator GoBedRoomArea(float delay)
    {
        yield return new WaitForSeconds(delay);
        GoBedAreaCanvasLogic();
    }

           private IEnumerator MarkedPillowAreaCollider(float delay)
    {
        yield return new WaitForSeconds(delay);
        MarkBedRoomCollider.SetActive(true);
    }

         private IEnumerator StartSetUpBedGuide(float delay)
    {
        yield return new WaitForSeconds(delay);
         StartSetUpBedAreaCanvasLogic();
    }
}
