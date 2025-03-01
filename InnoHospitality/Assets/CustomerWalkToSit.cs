using UnityEngine;

public class CustomerWalkToSit : MonoBehaviour
{
    public GameObject CustomerStandUp, CustomerSit;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player has collided with a box (or any specific tag if you want)
        if (collision.gameObject.CompareTag("Customer"))
        {
            CustomerStandUp.SetActive(false);
            CustomerSit.SetActive(true);
        }
    }
}
