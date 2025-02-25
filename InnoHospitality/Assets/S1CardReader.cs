using UnityEngine;
using System.Collections;

public class S1CardReader : MonoBehaviour
{
    public MeshRenderer CardReader;
    public GameObject Card; // Assign this in the Inspector
    private Color originalColor; // Store the original color
    public S1CanvasManager s1CanvasManager;
    public BoxCollider doorKnobEntrance;
    private bool hasTriggered = false; // Flag to track if it has already executed

    private void Start()
    {
        originalColor = CardReader.material.color; // Save the original color at the start
        doorKnobEntrance.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Card && !hasTriggered) // Check if the colliding object is the specific GameObject
        {
            StartCoroutine(ChangeColorAfterDelay());
        }
    }

    private IEnumerator ChangeColorAfterDelay()
    {
        hasTriggered = true; // Set flag so it doesn't run again
        yield return new WaitForSeconds(3f); // Wait for 3 seconds
        CardReader.material.color = Color.green; // Change to green
        yield return new WaitForSeconds(3f); // Wait another 3 seconds
        CardReader.material.color = originalColor; // Revert back to the original color
         s1CanvasManager.OpenDoorCanvasLogic();
         doorKnobEntrance.enabled = true;
        
    }
}
