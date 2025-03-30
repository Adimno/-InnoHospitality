using UnityEngine;

public class BathRoomDoorPlayer : MonoBehaviour
{
         public GameObject Player;

        public S1CanvasManager s1CanvasManager;

    private bool hasTriggered = false; // Flag to track if it has already executed

    void Start(){


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            s1CanvasManager.BathRoomCanvasLogic();
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
