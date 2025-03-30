using UnityEngine;

public class S1GoBathroomGuide : MonoBehaviour
{
   public GameObject Player;
    public S1CanvasManager s1CanvasManager;
    public MeshRenderer meshKitchen;

    private bool hasTriggered = false; // Flag to track if it has already executed

 

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            s1CanvasManager.OpenDoorBathroomCanvasLogic();
            meshKitchen.enabled = false;
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
