using UnityEngine;

public class S1BathRoomObjectsTracker : MonoBehaviour
{
    public GameObject[] objectsBath; // Array of GameObjects to track
    public GameObject[] GameObjectFalse; // GameObjects to deactivate
    public S1CanvasManager s1CanvasManager;
    private bool hasTriggered = false;

    void Update()
    {
        if (AllObjectsEnabled() && !hasTriggered) // Check all objects
        {
            hasTriggered = true; // Prevent multiple calls
            s1CanvasManager.AppliancesLookCanvasLogic(); 
            
            foreach (GameObject obj in GameObjectFalse) 
            {
                obj.SetActive(false);
            }
        }
    }

    bool AllObjectsEnabled()
    {
        foreach (GameObject obj in objectsBath)
        {
            if (!obj.activeSelf) // If any GameObject is not active, return false
            {
                return false;
            }
        }
        return true; // If all objects are active, return true
    }
}
