using UnityEngine;
using System.Collections;

public class UtensilCounter : MonoBehaviour
{
    private int previousCounter = -1; // Stores the last counter value
    public int counter = 0;
    public GameObject D4, arrow;
    private bool hasActivated = false; // Flag to ensure activation runs only once
    public S2IconLogic icon;
    public TotalPoints points;
    public TotalProgress progress;
    public AudioSource correct;

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
        if (counter < 7)
        {
            Debug.Log("INCOMPLETE " + counter);
        }
        else if (counter == 7 && !hasActivated) // Ensure it runs only once
        {
            icon.ShowArrange1();
            correct.Play();
            progress.IncrementProgress(8.33f);
            points.IncrementPoints(10);
            Debug.Log("COMPLETE " + counter);
            hasActivated = true; // Set flag to true
            StartCoroutine(ActivateD4WithDelay()); // Start the coroutine
        }
    }

    private IEnumerator ActivateD4WithDelay()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        D4.SetActive(true);
        arrow.SetActive(false);
    }
}
