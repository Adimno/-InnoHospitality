using UnityEngine;

public class UtensilsSnap : MonoBehaviour
{
    public GameObject utensil;
    public UtensilCounter count;


    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == utensil)
        {
            count.Increment();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == utensil)
        {
            count.Decrement();
        }
    }
}
