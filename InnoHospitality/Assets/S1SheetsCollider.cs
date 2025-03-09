using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class S1SheetsCollider : MonoBehaviour
{
 
    public  MeshRenderer SheetCollider;
    public GameObject Sheet;
    public  GameObject HideGrabSheet;

    private bool hasTriggered = false; // Flag to track if it has already executed

 

     private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject == Sheet && !hasTriggered) // Ensure it only runs once
        {
            HideGrabSheet.SetActive(false);
            SheetCollider.enabled = true;
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
