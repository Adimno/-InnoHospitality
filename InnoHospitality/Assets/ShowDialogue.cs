using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    public GameObject Player, D5, CustomerMark;

    void OnTriggerEnter(Collider other)
    {
        // Check if the other gameObject is the Player
        if (other.gameObject == Player)
        {
            D5.SetActive(true); // Show dialogue or perform another action
            CustomerMark.SetActive(false);
        }
    }
}
