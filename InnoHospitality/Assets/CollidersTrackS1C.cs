using UnityEngine;

public class CollidersTrackS1C : MonoBehaviour
{
   public GameObject[] objectsToCheck;
   public CutSceneCanvasManager CutSceneS1;
   private bool hasTriggered = false; // Flag to track if it has already executed


      // Returns true if all GameObjects are inactive
    public bool AreAllInactive()
    {
        foreach (GameObject obj in objectsToCheck)
        {
            if (obj.activeSelf) // If any one is active
                return false;
        }
        return true; // All are inactive
    }

    void Update()
    {
        if (AreAllInactive())
        {
            CutSceneS1.CongratsCanvasCanvasLogic();
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}

