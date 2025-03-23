using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

public class WaterController : MonoBehaviour
{
    public ParticleSystem waterParticles;
    public AudioSource waterSound;

    private InputDevice rightHandDevice;
    public bool isGripPressed = false;
    public bool isButtonPressed = false;
    public static InputFeatureUsage<bool> gripButton = CommonUsages.gripButton;
    public static InputFeatureUsage<bool> triggerButton = CommonUsages.triggerButton;

    void Start()
    {
        InitializeXRInput();
        if (waterParticles != null)
        {
            var emissionModule = waterParticles.emission;
            emissionModule.enabled = false;
        }
    }

    private void InitializeXRInput()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right, devices);
        if (devices.Count > 0)
        {
            rightHandDevice = devices[0];
            Debug.Log("Right Hand Controller Found");
        }
        else
        {
            Debug.LogWarning("No Right Hand Controller Found!");
        }
    }

    void Update()
    {
        if (!rightHandDevice.isValid)
        {
            InitializeXRInput();
            return;
        }

        rightHandDevice.TryGetFeatureValue(gripButton, out isGripPressed);
        rightHandDevice.TryGetFeatureValue(triggerButton, out isButtonPressed);

        if (isGripPressed && isButtonPressed)
        {
            ToggleWaterEffect(true);
        }
        else
        {
            ToggleWaterEffect(false);
        }
    }

    private void ToggleWaterEffect(bool isActive)
    {
        if (waterParticles != null)
        {
            var emissionModule = waterParticles.emission;
            emissionModule.enabled = isActive;
        }

        if (waterSound != null)
        {
            if (isActive)
                waterSound.Play();
            else
                waterSound.Stop();
        }
    }
}