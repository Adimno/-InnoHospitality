using UnityEngine;

public class S1BathObjectsCollider : MonoBehaviour
{
  public  GameObject BathCollider;
    public GameObject BathObject;
    public  GameObject HideGrabObject;
    public GameObject HideSnap;

    private bool hasTriggered = false; // Flag to track if it has already executed

 

     private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject == BathObject && !hasTriggered) // Ensure it only runs once
        {
            HideGrabObject.SetActive(false);
            HideSnap.SetActive(false);
            BathCollider.SetActive(true);
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
