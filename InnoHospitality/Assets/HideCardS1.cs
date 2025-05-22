using UnityEngine;

public class HideCardS1 : MonoBehaviour
{
     public GameObject Card; // Assign this in the Inspector
     public GameObject Player;

     private bool hasTriggered = false; // Flag to track if it has already executed

       private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Check if the colliding object is the specific GameObject
        {
             hasTriggered = true;
            Card.SetActive(false);
        }
    }
}
