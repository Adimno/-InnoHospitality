using UnityEngine;

public class Order1Snap : MonoBehaviour
{
    public GameObject order;
    public Order1Counter count;

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == order)
        {
            count.Increment();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == order)
        {
            count.Decrement();
        }
    }
}
