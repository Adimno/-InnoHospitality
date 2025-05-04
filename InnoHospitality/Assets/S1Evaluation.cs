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
            evaluationText.text = "Evaluation Result:\nExcellent housekeeping performance. Keep up the outstanding work!";
        }
        else if (score >= 100)
        {
            evaluationText.text = "Evaluation Result:\nGood job! Your housekeeping skills are above average.";
        }
        else if (score >= 80)
        {
            evaluationText.text = "Evaluation Result:\nSatisfactory housekeeping. There’s room for improvement.";
        }
        else
        {
            evaluationText.text = "Evaluation Result:\nNeeds improvement. Please review housekeeping standards.";
        }
    }
}
