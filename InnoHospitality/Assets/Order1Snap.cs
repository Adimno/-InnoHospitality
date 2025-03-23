using UnityEngine;

public class Order1Snap : MonoBehaviour
{
    public GameObject order;
    public Order1Counter count;
    public GameObject[] utensilNoMesh; // Array to hold multiple parts

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == order)
        {
            count.Increment();
            // Disable the MeshRenderer of all utensils in the array
            foreach (GameObject utensil in utensilNoMesh)
            {
                if (utensil != null)
                {
                    MeshRenderer meshRenderer = utensil.GetComponent<MeshRenderer>();
                    if (meshRenderer != null)
                    {
                        meshRenderer.enabled = false; // Disable the renderer
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collided object is the specified utensil
        if (other.gameObject == order)
        {
            count.Decrement();
            // Enable the MeshRenderer of all utensils in the array
            foreach (GameObject utensil in utensilNoMesh)
            {
                if (utensil != null)
                {
                    MeshRenderer meshRenderer = utensil.GetComponent<MeshRenderer>();
                    if (meshRenderer != null)
                    {
                        meshRenderer.enabled = true; // Enable the renderer
                    }
                }
            }
        }
    }
}
