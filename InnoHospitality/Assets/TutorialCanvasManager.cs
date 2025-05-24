using UnityEngine;

public class TutorialCanvasManager : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject ProceedCanvas;
    public GameObject NextRoomCanvas;
    public GameObject Portal;


  public void WelcomeCanvasLogic()
   {
     WelcomeCanvas.SetActive(true);
     ProceedCanvas.SetActive(false);
      NextRoomCanvas.SetActive(false);
   }

   public void NextRoomCanvasLogic(){
       ProceedCanvas.SetActive(false);
       NextRoomCanvas.SetActive(true);
        WelcomeCanvas.SetActive(false);
   }

   public void ProceedCanvasLogic(){
       ProceedCanvas.SetActive(true);
        WelcomeCanvas.SetActive(false);
        NextRoomCanvas.SetActive(false);
        Portal.SetActive(true);
   }
}
