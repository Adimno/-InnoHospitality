using UnityEngine;

public class BioColliders : MonoBehaviour
{
    public GameObject[] ChecklistTrash; // List of trash objects
    public GameObject[] CheckIcon; // Corresponding check icons

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
        for (int i = 0; i < ChecklistTrash.Length; i++)
        {
            if (ChecklistTrash[i] != null && other.gameObject == ChecklistTrash[i]) // Ensure valid reference and check match
            {
                if (CheckIcon[i] != null && !CheckIcon[i].activeSelf) // Ensure it hasn't been counted yet
                {
                    CheckIcon[i].SetActive(true); // Enable check icon
                    TrashManager.instance.CollectTrash(); // Update global count
                }
            }
        }
    }
}
