using UnityEngine;

public class ShowNextCanvas : MonoBehaviour
{
    public GameObject WaterStaticTrue;

    private bool hasTriggered = false;

    public S1CanvasManager s1CanvasManager;

    void Update() // Fixed typo: should be Update(), not Updated()
    {
        if (WaterStaticTrue.activeSelf && !hasTriggered)
        {
      
            s1CanvasManager.CleanSinkCanvasLogic();
            hasTriggered = true; 
        }
    }
}
