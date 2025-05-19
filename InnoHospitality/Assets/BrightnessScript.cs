using UnityEngine;

public class BrightnessScript : MonoBehaviour
{
    public float brightness = 1f; // Default brightness
    public Light directionalLight;

    private float lastBrightness = -1f; // To track changes and avoid unnecessary updates

    private void Start()
    {
        directionalLight = GameObject.FindObjectOfType<Light>();
        if (directionalLight == null || directionalLight.type != LightType.Directional)
            Debug.LogWarning("No Directional Light found in the scene.");

        brightness = PlayerPrefs.GetFloat("Brightness", 1f);
        ApplyBrightness(brightness);
        lastBrightness = brightness;
    }

    void Update()
    {
        // Only update if brightness value changed (to avoid repeated writes & apply)
        if (!Mathf.Approximately(brightness, lastBrightness))
        {
            lastBrightness = brightness;
            PlayerPrefs.SetFloat("Brightness", brightness);
            ApplyBrightness(brightness);
        }
    }

    private void ApplyBrightness(float value)
    {
        if (directionalLight != null)
            directionalLight.intensity = value;
    }
}
