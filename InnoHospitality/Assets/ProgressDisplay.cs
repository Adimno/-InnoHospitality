using UnityEngine;
using TMPro;

public class ProgressDisplay : MonoBehaviour
{
    public TMP_Text progressText;              // Assign in Inspector
    public TotalProgress totalProgressScript;  // Reference to TotalProgress script

    void Update()
    {
        if (progressText != null && totalProgressScript != null)
        {
            float currentProgress = totalProgressScript.ProgressValue;
            progressText.text = currentProgress.ToString("F0") + "%";
        }
    }
}
