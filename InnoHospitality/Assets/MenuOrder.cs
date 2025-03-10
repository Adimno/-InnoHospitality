using UnityEngine;
using System.Collections;

public class MenuOrder : MonoBehaviour
{
    public GameObject check, wrong;
    private bool isCheckActive = false; // Track the current state
    private bool canClick = true; // Prevent multiple rapid triggers

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger") && canClick)
        {
            StartCoroutine(ToggleState());
        }
    }

    private IEnumerator ToggleState()
    {
        canClick = false; // Disable clicking
        isCheckActive = !isCheckActive; // Toggle state

        check.SetActive(isCheckActive);
        wrong.SetActive(!isCheckActive);

        Debug.Log("Player collided. Check is " + isCheckActive);

        yield return new WaitForSeconds(1f); // Wait 1 second
        canClick = true; // Re-enable clicking
    }
}
