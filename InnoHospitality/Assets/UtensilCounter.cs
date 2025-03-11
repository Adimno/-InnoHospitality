using UnityEngine;

public class UtensilCounter : MonoBehaviour
{
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

    public void CheckerCount()
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
