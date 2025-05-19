using UnityEngine;

public class BrightnessReader : MonoBehaviour
{
    public Light directionalLight;
    private float brightness;

    void Start()
    {
        // Load the brightness that was saved in the previous scene
        brightness = PlayerPrefs.GetFloat("Brightness", 1f);
        Debug.Log("Current brightness loaded: " + brightness);

        if (directionalLight != null)
        {
            directionalLight.intensity = brightness;
        }
    }
}
