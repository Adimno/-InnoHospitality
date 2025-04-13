using UnityEngine;

public class S1BathRoomObjectsTracker : MonoBehaviour
{
    public GameObject[] objectsBath; // Array of GameObjects to track
    public GameObject[] GameObjectFalse; // GameObjects to deactivate
    public S1CanvasManager s1CanvasManager;
    private bool hasTriggered = false;

    public TotalPoints points;
    public S1IconLogic Icon;
    public TimeLogic time;

    void Update()
    {
        if (AllObjectsEnabled() && !hasTriggered)
        {
            hasTriggered = true;
            s1CanvasManager.GameFinishCanvasLogic(); 
            time.PauseTimer();
            Icon.BathIconLogic();

            double basePoints = 20;
            double bonusPoints = CalculateTimeBonus(time.GetElapsedTime());
            points.IncrementPoints(basePoints + bonusPoints);

            foreach (GameObject obj in GameObjectFalse)
            {
                obj.SetActive(false);
            }
        }
    }

    bool AllObjectsEnabled()
    {
        foreach (GameObject obj in objectsBath)
        {
            if (!obj.activeSelf)
                return false;
        }
        return true;
    }

    double CalculateTimeBonus(float elapsedTime)
    {
        if (elapsedTime <= 240f) // ≤ 4 minutes
        {
            return 30;
        }
        else if (elapsedTime <= 300f) // ≤ 5 minutes
        {
            return 20;
        }
        else if (elapsedTime <= 360f) // ≤ 6 minutes
        {
            return 10;
        }
        return 0;
    }
}
