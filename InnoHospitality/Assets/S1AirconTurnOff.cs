using UnityEngine;

public class S1AirconTurnOff : MonoBehaviour
{
    public MeshRenderer AirconBox;
    public AudioSource audioSource;

    private Color originalColor;
    private bool isRed = false;

    private void Start()
    {
        originalColor = AirconBox.material.color;

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogError("No AudioSource found on " + gameObject.name);
            }
        }
    }

    public void ChangeColor()
    {
        if (isRed)
        {
            // Revert to original color and re-enable audio
            AirconBox.material.color = originalColor;
            audioSource.enabled = true;
            isRed = false;
        }
        else
        {
            // Change to red and disable audio
            AirconBox.material.color = Color.red;
            audioSource.enabled = false;
            isRed = true;
        }
    }
}
