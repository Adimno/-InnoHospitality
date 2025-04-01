using UnityEngine;

public class S1BathRoomObjectsTracker : MonoBehaviour
{
    public GameObject[] objectsBath; // Array of GameObjects to track
    public GameObject[] GameObjectFalse; // GameObjects to deactivate
    public S1CanvasManager s1CanvasManager;
    private bool hasTriggered = false;

    public TotalPoints points;
     public S1IconLogic Icon;

     public TimeLogic time;

    void Update()
    {
        if (AllObjectsEnabled() && !hasTriggered) // Check all objects
        {
            hasTriggered = true; // Prevent multiple calls
            s1CanvasManager.GameFinishCanvasLogic(); 
            time.PauseTimer();
            points.IncrementPoints(20);
                        Icon.BathIconLogic();

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
