using UnityEngine;

public class S1GoPillowGuide : MonoBehaviour
{
     public GameObject Player;
    public S1CanvasManager s1CanvasManager;
    public MeshRenderer meshKitchen;
    public  GameObject PillowsSheetGuide;

    private bool hasTriggered = false; // Flag to track if it has already executed

 

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
              PillowsSheetGuide.SetActive(true);
            meshKitchen.enabled = false;
            s1CanvasManager.GoBedroomMarkedAreaCanvasLogic();
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
