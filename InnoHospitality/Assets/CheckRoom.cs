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
        for (int i = 0; i < objectsToCheck.Length; i++)
        {
            if (!objectsToCheck[i].activeSelf && !hasTriggered)
            {

            hasTriggered = true;
            s1CanvasManager.GameFinishCanvasLogic(); 
            time.PauseTimer();
            Icon.BathIconLogic();

            double basePoints = 20;
            double bonusPoints = CalculateTimeBonus(time.GetElapsedTime());
            points.IncrementPoints(basePoints + bonusPoints);
                
            }
        }
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