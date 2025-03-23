using UnityEngine;

public class IMUCanvas : MonoBehaviour
{
     public GameObject Player;

    public MeshRenderer meshKitchen;
    public GameObject IMUCanvasObject;

      public GameObject IMUCanvasChecklist;

    private bool hasTriggered = false; // Flag to track if it has already executed

    private void Start(){
        IMUCanvasObject.SetActive(false);
        IMUCanvasChecklist.SetActive(false);
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
                IMUCanvasChecklist.SetActive(true);
            IMUCanvasObject.SetActive(true);
            meshKitchen.enabled = false;
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
