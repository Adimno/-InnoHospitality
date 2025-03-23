using UnityEngine;
using System.Collections;

public class ShowDialogue : MonoBehaviour
{
    public GameObject Player, CustomerMark;
    public CustomerWalkToTable customer1;

    void OnTriggerEnter(Collider other)
    {
        // Check if the other gameObject is the Player
        if (other.gameObject == Player)
        {
            customer1.StartWalking();
            
            StartCoroutine(ActivateD5WithDelay()); // Start the coroutine
        }
    }

    private IEnumerator ActivateD5WithDelay()
    {
        yield return new WaitForSeconds(3); // Wait for 2 seconds
        CustomerMark.SetActive(false);
    }
}
