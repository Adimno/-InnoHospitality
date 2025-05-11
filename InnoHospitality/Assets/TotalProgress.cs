using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class TotalProgress : MonoBehaviour
{
    public TMP_Text progressText; // Assign TMP_Text in Inspector
    private float progressValue = 0f; // Track progress manually

    // Public getter for progressValue
    public float ProgressValue
    {
        get { return progressValue; }
    }

    void Start()
    {
        progressValue = 0f; // Start at 0%
        UpdateProgressText(); // Initialize text
    }

    public void IncrementProgress(float amount)
    {
        progressValue += amount;
        if (progressValue > 100f)
        {
            progressValue = 100f; // Clamp at 100%
        }
        UpdateProgressText(); // Update text after increment
    }

    private void UpdateProgressText()
    {
        progressText.text = progressValue.ToString("F0") + "%"; // Show whole number only
    }
}
