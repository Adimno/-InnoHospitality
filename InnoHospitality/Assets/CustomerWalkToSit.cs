using UnityEngine;

public class CustomerWalkToSit : MonoBehaviour
{
    public GameObject CustomerStandUp, CustomerSit, canvas;

    void OnTriggerEnter(Collider other)
    {
        // Check if the player has collided with a box (or any specific tag if you want)
        if (other.gameObject.CompareTag("Customer"))
        {
            CustomerStandUp.SetActive(false);
            CustomerSit.SetActive(true);
            canvas.SetActive(true);
            Debug.Log("Customer Collided with box");
        }
    }
}
