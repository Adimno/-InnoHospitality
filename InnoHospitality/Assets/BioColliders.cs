using UnityEngine;
using System;

public class BioColliders : MonoBehaviour
{
    public GameObject[] ChecklistTrash; // List of correct trash objects
    public GameObject[] WrongTrash; // List of wrong trash objects
    public GameObject[] CheckIcon; // Corresponding check icons
    public AudioSource music; // Correct sound
    public AudioSource wrongSound; // Wrong sound

    public TotalPoints totalPoints;

    void Start()
    {
        // Disable all check icons at the start
        foreach (GameObject icon in CheckIcon)
        {
            if (icon != null)
            {
                icon.SetActive(false);
            }
        }

        // Register this bin's trash count with TrashManager
        TrashManager.instance.RegisterTrash(ChecklistTrash.Length);
    }

    private void OnTriggerEnter(Collider other)
    {
        bool isCorrect = false;

        for (int i = 0; i < ChecklistTrash.Length; i++)
        {
            if (ChecklistTrash[i] != null && other.gameObject == ChecklistTrash[i]) // Ensure valid reference and check match
            {
                if (CheckIcon[i] != null && !CheckIcon[i].activeSelf) // Ensure it hasn't been counted yet
                {
                    CheckIcon[i].SetActive(true); // Enable check icon
                    TrashManager.instance.CollectTrash(); // Update global count
                    music.Play(); // Play correct sound
                    isCorrect = true;
                }
                break; // Stop checking once matched
            }
        }

        // If not correct, check if it's in the wrong trash list
        if (!isCorrect)
        {
            foreach (GameObject wrong in WrongTrash)
            {
                if (wrong != null && other.gameObject == wrong)
                {
                    totalPoints.DecrementPoints(1);
                    wrongSound.Play(); // Play wrong sound
                    break;
                }
            }
        }
    }
}
