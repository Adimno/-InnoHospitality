using UnityEngine;

public class S1AirconTurnOff : MonoBehaviour
{

    public MeshRenderer AirconBox;
    public AudioSource audioSource; 
    private Color originalColor; // Store the original color
     private bool hasTriggered = false; // Flag to track if it has already executed
    private void Start()
    {
        originalColor = AirconBox.material.color; // Save the original color at the start

        // Ensure AudioSource is assigned
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found on " + gameObject.name);
        }
    }

    public void ChangeColor(){
        hasTriggered = true; // Set flag so it doesn't run again
        audioSource.enabled = false;
        AirconBox.material.color = Color.red; // Change to red
    }
}


