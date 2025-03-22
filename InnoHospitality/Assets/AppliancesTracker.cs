using UnityEngine;

public class AppliancesTracker : MonoBehaviour
{
    public GameObject[] appliances; // Array of appliances
    public AudioSource audioSource; // Reference to the AudioSource
    public S1CanvasManager s1CanvasManager; // Reference to Canvas Manager

    void Update()
    {
        if (AreAllAppliancesInactive() && IsSoundInactive()) 
        {
            Debug.Log("All appliances and sound are turned off.");
            s1CanvasManager.AppliancesLookCanvasLogic();
        }
    }

    bool AreAllAppliancesInactive()
    {
        if (appliances.Length == 0) return false; // Ensure array is not empty

        foreach (GameObject appliance in appliances)
        {
            if (appliance != null && appliance.activeSelf)
            {
                return false; // Return false if any appliance is active
            }
        }
        return true;
    }

    bool IsSoundInactive()
    {
        return audioSource == null || !audioSource.isPlaying;
    }
}
