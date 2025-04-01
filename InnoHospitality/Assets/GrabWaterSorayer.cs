using UnityEngine;
using System.Collections;

public class GrabWaterSprayer : MonoBehaviour
{
    public GameObject waterSprayer, waterSprayerHand;
    public GameObject Hand1, Hand2;
    public S1CanvasManager s1CanvasManager;

    void Start()
    {
        waterSprayer.SetActive(true);
        waterSprayerHand.SetActive(false);
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
        s1CanvasManager.CleaningCanvasLogic();
        waterSprayerHand.SetActive(true);
    }
}
