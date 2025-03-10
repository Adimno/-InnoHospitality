using UnityEngine;

public class CheckOrder : MonoBehaviour
{
    public bool[] orders = new bool[11]; // 11 boolean array, all false by default

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            CheckForChicken();
        }
    }

    public void CheckForChicken()
    {
        bool correctIndexes = orders[4] && orders[5] && orders[7] && orders[9];
        bool otherIndexesFalse = true;

        // Check that all other indices (except 4, 5, 7, 9) are false
        for (int i = 0; i < orders.Length; i++)
        {
            if (i != 4 && i != 5 && i != 7 && i != 9 && orders[i])
            {
                otherIndexesFalse = false;
                break;
            }
        }

        if (correctIndexes && otherIndexesFalse)
        {
            Debug.Log("Chicken");
        }
        else
        {
            Debug.Log("Not Chicken");
        }
    }
}
