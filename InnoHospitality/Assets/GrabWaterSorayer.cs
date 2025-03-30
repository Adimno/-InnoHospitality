using UnityEngine;
using System.Collections;

public class GrabWaterSprayer : MonoBehaviour
{
    public GameObject waterSprayer, waterSprayerHand;
    public GameObject CleaningCanvas;
    public GameObject Hand1, Hand2;

    void Start()
    {
        waterSprayer.SetActive(true);
        waterSprayerHand.SetActive(false);
        CleaningCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Hand1 || other.gameObject == Hand2)
        {
            StartCoroutine(SwitchSprayer());
        }
    }

    private IEnumerator SwitchSprayer()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        waterSprayer.SetActive(false);
        waterSprayerHand.SetActive(true);
        CleaningCanvas.SetActive(true);
    }
}
