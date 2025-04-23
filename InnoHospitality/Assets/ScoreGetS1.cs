using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreTimeGetS1 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public TextMeshProUGUI timerText;
    
    // scripts
    public TotalPoints totalPoints;
    public TimeLogic timeLogic;

    void Update()
{
    // Update score text
    textMeshPro.text = "Score: " + totalPoints.Points + " pts";

    // Get time from TimeLogic and format it
    float time = timeLogic.elapsedTime;
    int minutes = Mathf.FloorToInt(time / 60);
    int seconds = Mathf.FloorToInt(time % 60);
    timerText.text = $"Time: {minutes:D2}:{seconds:D2}";
}

}

