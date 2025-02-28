using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class BioColliders : MonoBehaviour
{
    public GameObject[] ChecklistTrash; // List of trash objects
    public GameObject[] CheckIcon; // Corresponding check icons
    public TextMeshProUGUI countText; // Reference to the TextMeshPro UI for count display

    private int trashCount = 0; // Counter for collected trash

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < ChecklistTrash.Length; i++)
        {
            if (ChecklistTrash[i] != null && other.gameObject == ChecklistTrash[i]) // Ensure valid reference and check match
            {
                if (CheckIcon[i] != null && !CheckIcon[i].activeSelf) // Ensure it hasn't been counted yet
                {
                    CheckIcon[i].SetActive(true); // Enable check icon
                    trashCount++; // Increase the counter
                    UpdateCountText(); // Update the UI
                }
            }
        }
    }

    private void UpdateCountText()
    {
        if (countText != null)
        {
            countText.text =  + trashCount + "/" + ChecklistTrash.Length;
        }
    }
}
