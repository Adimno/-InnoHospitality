using UnityEngine;

public class CheckRoom : MonoBehaviour
{
    public GameObject[] objectsToCheck;
    public S1CanvasManager s1CanvasManager;
    private bool hasTriggered = false;

    public TotalPoints points;
    public S1IconLogic Icon;
    public TimeLogic time;

    void Update()
    {
        if (!hasTriggered && AllObjectsDisabled())
        {
            hasTriggered = true;

            s1CanvasManager.GameFinishCanvasLogic(); 
            time.PauseTimer();
            Icon.BathIconLogic();

            double basePoints = 10;
            double bonusPoints = CalculateTimeBonus(time.GetElapsedTime());
            points.IncrementPoints(basePoints + bonusPoints);
        }
    }

    bool AllObjectsDisabled()
    {
        foreach (GameObject obj in objectsToCheck)
        {
            if (obj.activeSelf)
            {
                return false; // One object still active
            }
        }
        return true; // All objects are inactive
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
