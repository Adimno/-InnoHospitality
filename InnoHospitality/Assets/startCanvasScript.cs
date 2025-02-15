using UnityEngine;

public class startCanvasScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject StartCanvas; // Reference to button 
  


    void Start()
    {
      
    }

      public void startCanvas()
    {
        if (StartCanvas != null)
        {
            MainMenu.SetActive(false);  // hiding the canvas 
            StartCanvas.SetActive(true); // showing the canvas
        }
    }

    public void HideCanvas()
    {
        if (StartCanvas != null)
        {
            MainMenu.SetActive(true);
            StartCanvas.SetActive(false);
        }
    }
}
