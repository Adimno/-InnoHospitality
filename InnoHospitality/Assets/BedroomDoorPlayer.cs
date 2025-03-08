using UnityEngine;

public class BedroomDoorPlayer : MonoBehaviour
{
      public GameObject Player;
    public  GameObject BedRoomGuide;
     public  GameObject PillowsSheetGuide;
        public S1CanvasManager s1CanvasManager;

    private bool hasTriggered = false; // Flag to track if it has already executed

    void Start(){

        BedRoomGuide.SetActive(false);
        PillowsSheetGuide.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            BedRoomGuide.SetActive(true);
              s1CanvasManager.BedroomCanvasLogic();
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
