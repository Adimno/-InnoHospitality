using UnityEngine;
using System.Collections;

public class MenuOrder : MonoBehaviour
{
    public GameObject check, wrong;
    public CheckOrder order; // Reference to CheckOrder script
    public int indexValue;   // Determines which order to update
    private bool isCheckActive = false;
    private bool canClick = true;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger") && canClick)
        {
            StartCoroutine(ToggleState());
        }
    }

    private IEnumerator ToggleState()
    {
        canClick = false;
        isCheckActive = !isCheckActive;

        check.SetActive(isCheckActive);
        wrong.SetActive(!isCheckActive);

        // Update the corresponding index in CheckOrder
        if (order != null && indexValue >= 0 && indexValue < order.orders.Length)
        {
            order.orders[indexValue] = isCheckActive;
            Debug.Log($"Order {indexValue} set to {isCheckActive}");
        }

        yield return new WaitForSeconds(1f);
        canClick = true;
    }

    public void ResetVisuals()
    {
        isCheckActive = false;
        check.SetActive(false);
        wrong.SetActive(true);

        if (order != null && indexValue >= 0 && indexValue < order.orders.Length)
        {
            order.orders[indexValue] = false;
            Debug.Log($"Order {indexValue} reset to false");
        }
    }

}
