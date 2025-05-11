using UnityEngine;
using System.Collections;

public class Order1Counter : MonoBehaviour
{
    private int previousCounter = -1; // Stores the last counter value
    public int counter = 0;
    private bool hasActivated = false; // Flag to ensure activation runs once
    public S2IconLogic icon;
    public AudioSource correct;
    public TimeLogicScene2 time;
    public TotalPoints points;
    double bonusPoints = 0;
    public S2CanvasManager canvas;
    public TotalProgress progress;

    public void Increment()
    {
        counter++;
        points.IncrementPoints(1);
        Debug.Log("Counter increment: " + counter);
    }

    public void Decrement()
    {
        counter--;
        points.DecrementPoints(1);
        Debug.Log("Counter decrement: " + counter);
    }

    void Update()
    {
        if (counter != previousCounter) // Only check if the counter changed
        {
            CheckerCount();
            previousCounter = counter; // Update the last recorded value
        }
    }

    private void CheckerCount()
    {
        if (counter < 4)
        {
            Debug.Log("INCOMPLETE " + counter);
        }
        else if (counter == 4 && !hasActivated) // Ensure it runs only once
        {
            icon.ServeOrderIcon();
            correct.Play();
            Debug.Log("COMPLETE " + counter);
            bonusPoints = CalculateTimeBonus(time.GetElapsedTime());
            points.IncrementPoints(10);
            progress.IncrementProgress(8.33f);
            hasActivated = true; // Set flag to true
            StartCoroutine(ActivateD4WithDelay()); // Start the coroutine
        }
    }

    private IEnumerator ActivateD4WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        canvas.DGetBillShow();
        
    }

    double CalculateTimeBonus(float elapsedTime)
    {
        if (elapsedTime <= 180f) // ≤ 3 minutes
        {
            return 30;
        }
        else if (elapsedTime <= 240f) // ≤ 4 minutes
        {
            return 20;
        }
        else if (elapsedTime <= 300f) // ≤ 5 minutes
        {
            return 10;
        }
        return 0;
    }
}
