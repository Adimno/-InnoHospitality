using UnityEngine;

public class UtensilCounter : MonoBehaviour
{
    private int previousCounter = -1; // Stores the last counter value
    public int counter = 0;

    public void Increment()
    {
        counter++;
        Debug.Log("Counter increment: " + counter);
    }

    public void Decrement()
    {
        counter--;
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
        else if (counter == 4)
        {
            Debug.Log("COMPLETE " + counter);
        }
    }
}
