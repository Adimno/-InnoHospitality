using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    public GameObject Player, D5, CustomerMark;
    public CustomerWalkToTable customer1;

    void OnTriggerEnter(Collider other)
    {
        // Check if the other gameObject is the Player
        if (other.gameObject == Player)
        {
            customer1.StartWalking();
            D5.SetActive(true); // Show dialogue or perform another action
            CustomerMark.SetActive(false);
        }
    }
}
