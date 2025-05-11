using UnityEngine;
using TMPro;

public class TimeDisplayS1 : MonoBehaviour
{
    public TMP_Text timeText;              // Assign in Inspector
    public TimeLogic time;           // Reference to TimeLogicScene2 script

    void Update()
    {
        if (timeText != null && time != null)
        {
            float currentTime = time.GetElapsedTime();

            int hours = Mathf.FloorToInt(currentTime / 3600);
            int minutes = Mathf.FloorToInt((currentTime % 3600) / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);

            timeText.text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}