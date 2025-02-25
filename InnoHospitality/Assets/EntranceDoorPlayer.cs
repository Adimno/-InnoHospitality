using UnityEngine;

public class EntranceDoorPlayer : MonoBehaviour
{
    public GameObject Player;
    public S1CanvasManager s1CanvasManager;

    private bool hasTriggered = false; // Flag to track if it has already executed

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            s1CanvasManager.KitchAreaCanvasLogic();
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
