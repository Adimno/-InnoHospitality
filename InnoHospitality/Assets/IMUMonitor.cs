using UnityEngine;

public class IMUMonitor : MonoBehaviour
{
 
  
    public GameObject[] objectsToMonitor;  
    public TutorialCanvasManager tutorialCanvasManager;

    public GameObject ProceedGame;

    void Update()
    {
        if (AllObjectsAreActive())
        {
            ProceedGame.SetActive(true);
            tutorialCanvasManager.ProceedCanvasLogic();
            
        }
        else
        {
            ProceedGame.SetActive(false);
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
