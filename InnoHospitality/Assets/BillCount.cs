using UnityEngine;

public class BillCount : MonoBehaviour
{
    private bool[] Bills = new bool[1];


    // Call this method with the index (0, 1, or 2) to set it to true
    public void SetTowelTrue(int index)
    {
        if (index >= 0 && index < Bills.Length)
        {
            Bills[index] = true;
            Debug.Log($"Towel {index} set to true");

            if (AllTrue())
            {
                Debug.Log("DONE NA PO");
            }
        }
        else
        {
            Debug.LogWarning("Invalid towel index");
        }
    }

    private bool AllTrue()
    {
        foreach (bool flag in Bills)
        {
            if (!flag)
                return false;
        }
        return true;
    }
}
