using UnityEngine;

public class CutSceneCanvasManager : MonoBehaviour
{
   
    public GameObject WelcomeCanvas;
    public GameObject ExploreRoomCanvas; 

    // Assets
    public BoxCollider doorCollider;

    void Start()
    {
        WelcomeCanvas.SetActive(true);
        ExploreRoomCanvas.SetActive(false);
    }

       public void WelcomeCanvasLogic()
    {
        WelcomeCanvas.SetActive(true);
        ExploreRoomCanvas.SetActive(false);
    }

        public void ExploreRoomCanvasLogic()
    {
        doorCollider.enabled = false;
        WelcomeCanvas.SetActive(false);
        ExploreRoomCanvas.SetActive(true);
    }
}
