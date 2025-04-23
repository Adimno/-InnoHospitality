using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreTimeGetS2 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    // scripts
    public TotalPoints totalPoints;

    void Update()
    {
        // Update score text
        textMeshPro.text = "Score: " + totalPoints.Points + " pts";

    }

}

