using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CanvasHouseKeepingVisibility : MonoBehaviour
{
    public Canvas Maincanvas;
    public GameObject QuitCanvas;  // GameObject instead of Canvas

    private bool isScriptActive = true;
    private InputDevice leftHandDevice;
    private InputDevice rightHandDevice;
    public static InputFeatureUsage<bool> primaryTouch = CommonUsages.primaryButton;

    private bool previousTouchStateLeft = false;
    private bool previousTouchStateRight = false;

    private void Start()
    {
        QuitCanvas.SetActive(false); // Ensure it's hidden initially
        InitializeXRInput();
        Maincanvas.enabled = true;
    }

    private void InitializeXRInput()
    {
        List<InputDevice> devices = new List<InputDevice>();

        // Get Left Hand Device
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left, devices);
        if (devices.Count > 0)
        {
            leftHandDevice = devices[0];
            Debug.Log($"Left Device Found: {leftHandDevice.isValid}");
        }
        else
        {
            Debug.LogWarning("No Left Hand Controller Found!");
        }

        devices.Clear();

        // Get Right Hand Device
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right, devices);
        if (devices.Count > 0)
        {
            rightHandDevice = devices[0];
            Debug.Log($"Right Device Found: {rightHandDevice.isValid}");
        }
        else
        {
            Debug.LogWarning("No Right Hand Controller Found!");
        }
    }

    private void Update()
    {
        if (!isScriptActive)
            return;

        bool leftPrimaryTouch = false;
        bool rightPrimaryTouch = false;

        if (leftHandDevice.isValid)
            leftHandDevice.TryGetFeatureValue(primaryTouch, out leftPrimaryTouch);

        if (rightHandDevice.isValid)
            rightHandDevice.TryGetFeatureValue(primaryTouch, out rightPrimaryTouch);

        // Toggle QuitCanvas using Left Controller's primary button
        if (leftPrimaryTouch && !previousTouchStateLeft)
        {
            QuitCanvas.SetActive(!QuitCanvas.activeSelf); // Toggle visibility
        }

        // Toggle Maincanvas using Right Controller's primary button
        if (rightPrimaryTouch && !previousTouchStateRight)
        {
            Maincanvas.enabled = !Maincanvas.enabled; // Toggle visibility
         
        }

        // Store previous states to prevent rapid toggling
        previousTouchStateLeft = leftPrimaryTouch;
        previousTouchStateRight = rightPrimaryTouch;
    }

    // Function to deactivate the script
    public void DeactivateScript()
    {
        QuitCanvas.SetActive(false);
        Maincanvas.enabled = false;
        isScriptActive = false;
    }
}
