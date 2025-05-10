using UnityEngine;

public class BillMoney : MonoBehaviour
{
    public GameObject BillSnap, BillBlue;
    public BillMoneyCount count;
    public int setCount;
    private bool hasCounted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCounted && other.CompareTag("BillMoney"))
        {
            hasCounted = true;

            // Disable the specific ColdCompress object that collided
            other.gameObject.SetActive(false);
            BillBlue.SetActive(false);
            BillSnap.SetActive(true);
            count.SetTowelTrue(setCount);

            // Instead of deactivating TowelBlue, just hide it visually and disable interaction
            BillBlue.GetComponent<Renderer>().enabled = false;
            BillBlue.GetComponent<Collider>().enabled = false;

            BillSnap.GetComponent<Renderer>().enabled = true;
            BillSnap.GetComponent<Collider>().enabled = true;

            Debug.Log("done");
        }
    }
}
