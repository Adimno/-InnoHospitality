using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;         // Assign in Inspector
    public TotalPoints totalPointsScript;     // Reference to TotalPoints script

    void Update()
    {
        if (scoreText != null && totalPointsScript != null)
        {
            double currentPoints = totalPointsScript.Points;
            scoreText.text = currentPoints + " points";
        }
    }
}
