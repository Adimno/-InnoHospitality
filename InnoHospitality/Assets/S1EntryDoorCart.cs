using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class S1EntryDoorCart : MonoBehaviour
{
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] XRGrabInteractableGrabs;// Array of XRGrabInteractable objects

    void Start()
    {
        // Enable only the first XRGrabInteractable, disable the rest
        for (int i = 0; i < XRGrabInteractableGrabs.Length; i++)
        {
            XRGrabInteractableGrabs[i].enabled = (i == 0);
        }
    }

    void Update()
    {
        for (int i = 0; i < XRGrabInteractableGrabs.Length - 1; i++)
        {
            GameObject currentObject = XRGrabInteractableGrabs[i].gameObject;

            // If the current GameObject is inactive, activate the next XRGrabInteractable
            if (!currentObject.activeSelf && !XRGrabInteractableGrabs[i + 1].enabled)
            {
                XRGrabInteractableGrabs[i + 1].enabled = true;
            }
        }
    }
}
