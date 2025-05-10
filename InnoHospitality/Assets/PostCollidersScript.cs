using UnityEngine;

public class PostCollidersScript : MonoBehaviour
{
     public GameObject Player;
    public  GameObject DisableCollider;
    private bool hasTriggered = false; // Flag to track if it has already executed

 

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            DisableCollider.SetActive(false);
            
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
