using UnityEngine;

public class UtensilsSnap : MonoBehaviour
{
    public GameObject utensil;

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == utensil)
        {
            Debug.Log("Utensil collided");
        }
    }
}
