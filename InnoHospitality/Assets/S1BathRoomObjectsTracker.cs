using UnityEngine;

public class S1BathRoomObjectsTracker : MonoBehaviour
{
    public GameObject[] objectsBath; // Array of GameObjects to track
    public GameObject[] GameObjectFalse; // GameObjects to deactivate
    public S1CanvasManager s1CanvasManager;
    private bool hasTriggered = false;

    public S1IconLogic Icon;

    void Update()
    {
        if (AllObjectsEnabled() && !hasTriggered)
        {
            hasTriggered = true;
            s1CanvasManager.PostCanvasLogic(); 
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
            if (!obj.activeSelf)
                return false;
        }
        return true;
    }

}
