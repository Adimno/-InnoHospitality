using UnityEngine;

public class IMUMonitor : MonoBehaviour
{
 
  
    public GameObject[] objectsToMonitor;  
    public TutorialCanvasManager tutorialCanvasManager;


    void Update()
    {
        if (AllObjectsAreActive())
        {
            tutorialCanvasManager.ProceedCanvasLogic();
            
        }

    }

    bool AllObjectsAreActive()
    {
        foreach (GameObject obj in objectsToMonitor)
        {
            if (obj == null || !obj.activeSelf) // Check if it's inactive
            {
                return false;
            }
        }
        return true;
    }
}
