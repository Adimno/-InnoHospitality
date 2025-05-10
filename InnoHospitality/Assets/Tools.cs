using UnityEngine;

public class Tools : MonoBehaviour
{

    private bool[] itemStatus = new bool[4] { false, false, false, false };
    public S2CanvasManager canvas;


    public void SetItemPicked(int index)
    {
        if (index >= 0 && index < itemStatus.Length)
        {
            itemStatus[index] = true;
            Debug.Log($"Item at index {index} set to true.");

  
            if (AllItemsPicked())
            {
                Debug.Log("All items picked! You're ready.");
                canvas.DCleanToolsShow();
            }
        }
        else
        {
            Debug.LogWarning("Index out of range!");
        }
    }

    private bool AllItemsPicked()
    {
        foreach (bool status in itemStatus)
        {
            if (!status) return false;
        }
        return true;
    }
}
