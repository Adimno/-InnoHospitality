using UnityEngine;

public class DirtyChecker : MonoBehaviour
{
    private bool[] itemStatus = new bool[7] { false, false, false, false, false, false, false };
    public S2CanvasManager canvas;
    public GameObject clean, disinfectant, rag;
    public TotalPoints points;
    public TotalProgress progress;
    public S2IconLogic icon;

    public void SetItemPicked(int index)
    {
        if (index >= 0 && index < itemStatus.Length)
        {
            itemStatus[index] = true;
            Debug.Log($"Item at index {index} set to true.");


            if (AllItemsPicked())
            {
                Debug.Log("All items picked! You're ready.");
                canvas.D3Show();
                progress.IncrementProgress(8.33f);
                points.IncrementPoints(10);
                icon.PreClean2Icon();
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
