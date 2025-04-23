using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLogicScene2 : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerTextQuit;
    public TextMeshProUGUI statusText1;
    public TextMeshProUGUI statusText2;

    public GameObject results;

    public AudioSource GameOverSound;
    public AudioSource disabledaudio;

    public bool startTimer = false;
    public bool isPaused = false;

    public float elapsedTime = 0f;
    private float targetTime = 600f; // 10 minutes
    private bool objectShown = false;

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        if (startTimer && !isPaused)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= targetTime && !objectShown)
            {
                objectShown = true;
                disabledaudio.enabled = false;
                startTimer = false;
                results.SetActive(true);
                // Update the two text fields
                GameOverSound.Play();
                statusText1.text = "Game Over!";
                statusText2.text = "You have run out of time.";
            }

            UpdateTimerDisplay(elapsedTime);
        }
    }

    public void StartTimer()
    {
        startTimer = true;
    }

    public void PauseTimer()
    {
        isPaused = true;
    }

    public void ResumeTimer()
    {
        isPaused = false;
    }

    public void UpdateTimerDisplay(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = $"Time: {minutes:D2}:{seconds:D2}";
        timerTextQuit.text = $"Time: {minutes:D2}:{seconds:D2}";
    }

    public float GetElapsedTime()
    {
        return elapsedTime;
    }
}
