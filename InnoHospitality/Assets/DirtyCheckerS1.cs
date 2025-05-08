using UnityEngine;

public class DirtyCheckerS1 : MonoBehaviour
{
    private bool[] itemStatus = new bool[7] { false, false, false, false, false, false, false };
    public S1CanvasManager canvas;


    public void SetItemPicked(int index)
    {
        if (index >= 0 && index < itemStatus.Length)
        {
            itemStatus[index] = true;
            Debug.Log($"Item at index {index} set to true.");


            if (AllItemsPicked())
            {
                Debug.Log("All items picked! You're ready.");
                canvas.LivingRoomCanvasLogic(); //change this 
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
