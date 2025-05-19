using UnityEngine;
using TMPro;

public class S1Evaluation : MonoBehaviour
{
    public TotalPoints totalPointsScript; // Link to the TotalPoints script
    public TextMeshProUGUI evaluationText; // UI text element for displaying evaluation

    void Update()
    {
        double score = totalPointsScript.Points;

        if (score >= 130)
        {
            evaluationText.text = "Excellent";
        }
        else if (score >= 100)
        {
            evaluationText.text = "Good job";
        }
        else if (score >= 80)
        {
            evaluationText.text = "Satisfactory";
        }
        else
        {
            evaluationText.text = "Bad";
        }
    }
}
