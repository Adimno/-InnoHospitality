using UnityEngine;

public class DirtyCheckerPost : MonoBehaviour
{
    private bool[] itemStatus = new bool[7] { false, false, false, false, false, false, false };
    public S2CanvasManager canvas;
    public GameObject clean, disinfectant, rag;
    public TotalPoints points;
    double bonusPoints = 0;
    public TimeLogicScene2 time;
    public TotalProgress progress;
    public S2IconLogic icon;
    public AudioSource correct;

    public void SetItemPicked(int index)
    {
        if (index >= 0 && index < itemStatus.Length)
        {
            itemStatus[index] = true;
            Debug.Log($"Item at index {index} set to true.");


            if (AllItemsPicked())
            {
                Debug.Log("All items picked! You're ready.");
                bonusPoints = CalculateTimeBonus(time.GetElapsedTime());
                time.PauseTimer();
                points.IncrementPoints(bonusPoints);
                progress.IncrementProgress(8.33f);
                icon.PostClean2Icon();
                canvas.ResultsShow();
                clean.SetActive(false);
                rag.SetActive(false);
                disinfectant.SetActive(false);
                correct.Play();
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

    double CalculateTimeBonus(float elapsedTime)
    {
        if (elapsedTime <= 300f) // ≤ 5 minutes
        {
            return 30;
        }
        else if (elapsedTime <= 420f) // ≤ 7 minutes
        {
            return 20;
        }
        else if (elapsedTime <= 540f) // ≤ 9 minutes
        {
            return 10;
        }
        return 0;
    }
}
