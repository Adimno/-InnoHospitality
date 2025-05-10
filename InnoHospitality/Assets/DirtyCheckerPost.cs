using UnityEngine;

public class DirtyCheckerPost : MonoBehaviour
{
    private bool[] itemStatus = new bool[7] { false, false, false, false, false, false, false };
    public S2CanvasManager canvas;
    public GameObject clean, disinfectant, rag;

    public void SetItemPicked(int index)
    {
        if (index >= 0 && index < itemStatus.Length)
        {
            itemStatus[index] = true;
            Debug.Log($"Item at index {index} set to true.");


            if (AllItemsPicked())
            {
                Debug.Log("All items picked! You're ready.");
                canvas.ResultsShow();
                clean.SetActive(false);
                rag.SetActive(false);
                disinfectant.SetActive(false);
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
