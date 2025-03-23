using UnityEngine;

public class UtensilsSnap2 : MonoBehaviour
{
    public GameObject utensil;
    public UtensilCounter2 count;
    public GameObject utensilNoMesh;


    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == utensil)
        {
            count.Increment();

            // Disable the MeshRenderer of utensilNoMesh
            if (utensilNoMesh != null)
            {
                MeshRenderer meshRenderer = utensilNoMesh.GetComponent<MeshRenderer>();
                if (meshRenderer != null)
                {
                    meshRenderer.enabled = false; // Disable the renderer
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == utensil)
        {
            count.Decrement();
            // Disable the MeshRenderer of utensilNoMesh
            if (utensilNoMesh != null)
            {
                MeshRenderer meshRenderer = utensilNoMesh.GetComponent<MeshRenderer>();
                if (meshRenderer != null)
                {
                    meshRenderer.enabled = true; // Disable the renderer
                }
            }
        }
    }
}
