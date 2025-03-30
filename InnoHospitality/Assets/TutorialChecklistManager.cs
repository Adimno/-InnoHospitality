using UnityEngine;

public class TutorialChecklistManager : MonoBehaviour
{
     public GameObject[] objectsToCheck; // Assign objects in the Inspector
    public BoxCollider targetCollider;     // Assign the collider you want to enable
    public TutorialCanvasManager tutorialCanvasManager;

    void Start(){
        foreach (GameObject obj in objectsToCheck)
        {
            obj.SetActive(false);
        }
    }

    void Update()
    {
        if (AllObjectsActive())  
        {
            targetCollider.enabled = false;  // Enable the collider
            tutorialCanvasManager.NextRoomCanvasLogic();
        }
    }

    bool AllObjectsActive()
    {
        foreach (GameObject obj in objectsToCheck)
        {
            if (!obj.activeInHierarchy)  // Check if any object is inactive
            {
                return false;
            }
        }
        return true;
    }
}
