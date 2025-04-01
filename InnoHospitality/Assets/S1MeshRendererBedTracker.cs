using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class S1MeshRendererBedTracker : MonoBehaviour
{
    public MeshRenderer[] bedMesh; // Array of MeshRenderers
    public GameObject[] GameObjectFalse; // The next GameObject to activate
     public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable[] XRGrabInteractableGrabs;// Array of XRGrabInteractable objects
         public S1CanvasManager s1CanvasManager;
    private bool hasTriggered = false;
    public TotalPoints points;

    void Start()
    {
        // Ensure the first XRGrab is enabled, and the rest are disabled
        for (int i = 0; i < XRGrabInteractableGrabs.Length; i++)
        {
            XRGrabInteractableGrabs[i].enabled = (i == 0);
        }
    }

  void Update()
{
    for (int i = 0; i < bedMesh.Length; i++)
    {
        if (bedMesh[i].enabled && i < XRGrabInteractableGrabs.Length - 1)
        {
            XRGrabInteractableGrabs[i + 1].enabled = true; 
        }
    }

    if (AllMeshesEnabled() && !hasTriggered) // Prevent multiple calls
    {
        hasTriggered = true; // Set flag so it doesn't run again
         points.IncrementPoints(20);
        s1CanvasManager.AppliancesLookCanvasLogic(); 
        foreach (GameObject GameObjectDisabled in GameObjectFalse) 
        {
            GameObjectDisabled.SetActive(false);
        }
    }
}


    bool AllMeshesEnabled()
    {
        foreach (MeshRenderer mesh in bedMesh)
        {
            if (!mesh.enabled) // If any mesh is not enabled, return false
            {
                return false;
            }
        }
        return true; // If all are enabled, return true
    }
}
