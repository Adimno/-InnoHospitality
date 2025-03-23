using UnityEngine;

public class TutorialCanvasManager : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject ProceedCanvas;


  public void WelcomeCanvasLogic()
   {
     WelcomeCanvas.SetActive(true);
     ProceedCanvas.SetActive(false);
   }

   public void ProceedCanvasLogic(){
       ProceedCanvas.SetActive(true);
        WelcomeCanvas.SetActive(false);
   }
}
