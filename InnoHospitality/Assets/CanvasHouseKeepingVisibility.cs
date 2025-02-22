using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CanvasHouseKeepingVisibility : MonoBehaviour
{
    public Canvas canvas;
    private bool isActive = false;
    private bool isScriptActive = true;

  //  private InputDevice leftHandDevice;
    private InputDevice rightHandDevice;
    public static InputFeatureUsage<bool> primaryTouch = CommonUsages.primaryButton; // Changed to primaryButton

    private bool previousTouchState = false; // Prevents rapid toggling

    private void Start()
    {
        InitializeXRInput();
        canvas.enabled = true; // Start with canvas open
    }

    private void InitializeXRInput()
    {
        List<InputDevice> devices = new List<InputDevice>();
      //  InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left, devices);
      //  if (devices.Count > 0)
      //  {
       //     leftHandDevice = devices[0];
     //   }

        devices.Clear();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right, devices);
        if (devices.Count > 0)
        {
            rightHandDevice = devices[0];
        }
    }

    private void Update()
    {
        if (!isScriptActive)
            return;

      //  bool leftPrimaryTouch = false;
        bool rightPrimaryTouch = false;

        //if (leftHandDevice.isValid)
      //      leftHandDevice.TryGetFeatureValue(primaryTouch, out leftPrimaryTouch);

        if (rightHandDevice.isValid)
            rightHandDevice.TryGetFeatureValue(primaryTouch, out rightPrimaryTouch);

        bool isTouching = rightPrimaryTouch;     // leftPrimaryTouch || rightPrimaryTouch;

        // Toggle only when state changes from false -> true
        if (isTouching && !previousTouchState)
        {
            isActive = !isActive;
            canvas.enabled = isActive;
        }

        previousTouchState = isTouching; // Store previous state
    }

    // Function to deactivate the script
    public void DeactivateScript()
    {
        canvas.enabled = false;
        isScriptActive = false;
    }
}
