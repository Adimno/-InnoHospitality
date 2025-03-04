using UnityEngine;

public class BedroomDoorPlayer : MonoBehaviour
{
      public GameObject Player;
    public  GameObject BedRoomGuide;

    private bool hasTriggered = false; // Flag to track if it has already executed

    void Start(){
        BedRoomGuide.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered) // Ensure it only runs once
        {
            BedRoomGuide.SetActive(true);
            hasTriggered = true; // Set flag so it doesn't run again
        }
    }
}
