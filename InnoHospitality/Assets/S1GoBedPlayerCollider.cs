using UnityEngine;

public class S1GoBedPlayerCollider : MonoBehaviour
{
    public GameObject Player;
    public S1CanvasManager s1CanvasManager;
    public MeshRenderer meshKitchen;

    private bool hasTriggered = false; // Flag to track if it has already executed

 

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            meshKitchen.enabled = false;
            s1CanvasManager.OpenBedDoorCanvasLogic();
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
