using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    // Expose the desired rotation, rotation speed, and target object in the Inspector
    [Header("Transform Settings")]
    public Vector3 desiredRotation = new Vector3(-0.087f, 180.316f, 0.205f);
    public float rotationSpeed = 90.0f; 
    public GameObject targetObject; 
    public AudioClip doorOpeningSound; 

    private AudioSource audioSource; 
    
    public GameObject LeftHand;
    
    public GameObject RightHand;

    private bool isOpening = false; 
    private bool soundPlayed = false; 

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == LeftHand || other.gameObject == RightHand)
        {
            Debug.Log("Player detected!!!!!!!! Opening door...");
            Debug.Log("Player detected! Opening door...");

            // Play the door opening sound if available and not already played
            if (doorOpeningSound != null && audioSource != null && !soundPlayed)
            {
                audioSource.PlayOneShot(doorOpeningSound);
                soundPlayed = true; // Set flag to indicate sound has been played
            }

            // Rotate the target object to the desired rotation
            isOpening = true; // Set flag to start rotating
        }
    }

    void Update()
    {
        if (isOpening)
        {
            // Calculate the target rotation
            Quaternion targetRotation = Quaternion.Euler(desiredRotation);

            // Rotate the target object towards the target rotation
            targetObject.transform.rotation = Quaternion.RotateTowards(targetObject.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the target object has reached the target rotation
            if (Quaternion.Angle(targetObject.transform.rotation, targetRotation) < 0.1f)
            {
                isOpening = false; // Stop rotating
            }
        }
    }
}
