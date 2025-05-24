using UnityEngine;

public class PortalRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // degrees per second

    // Update is called once per frame
    void Update()
    {
        // Rotate around the Z-axis
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
