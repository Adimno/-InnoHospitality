using UnityEngine;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
    [SerializeField] private Slider brightnessSlider;
    [SerializeField] private BrightnessScript brightnessScript;

    private void Start()
    {
        if (brightnessSlider == null || brightnessScript == null)
        {
            Debug.LogError("Assign both slider and BrightnessScript references in inspector!");
            return;
        }

        // Set slider range and initial value to match saved brightness
        brightnessSlider.minValue = 0f;
        brightnessSlider.maxValue = 5f;
        brightnessSlider.value = PlayerPrefs.GetFloat("Brightness", 3f);

        // Whenever slider changes, update brightness in BrightnessScript
        brightnessSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        brightnessScript.brightness = value;
    }
}
