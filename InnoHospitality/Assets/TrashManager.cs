using UnityEngine;
using TMPro;

public class TrashManager : MonoBehaviour
{
    public static TrashManager instance; // Singleton pattern for global tracking

    public TextMeshProUGUI countText; // UI text to show progress
    public TextMeshProUGUI countText1; // UI text to show progress
    public S1CanvasManager s1CanvasManager; // Message object to show when all trash is collected
    private int totalTrash = 0; // Total trash count
    private int collectedTrash = 0; // Counter for collected trash
     public TotalPoints points;
     public S1IconLogic Icon;

     public TotalProgress progress;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; // Set singleton instance
        }
        else
        {
            Destroy(gameObject); // Ensure only one manager exists
            return;
        }
    
    }

    public void RegisterTrash(int total) 
    {
        totalTrash += total; // Add to the total trash count
        UpdateCountText();
    }

    public void CollectTrash()
    {
        collectedTrash++; // Increase collected count
        UpdateCountText();

        if (collectedTrash >= totalTrash) // Check if all trash is collected
        {
            Icon.TrashIconLogic();
            progress.IncrementProgress(10);
             points.IncrementPoints(10);
              s1CanvasManager.CongratsTrashCanvasLogic(); // Show success message
        }
    }

    private void UpdateCountText()
    {
        if (countText != null)
        {
            countText1.text = collectedTrash + " / " + totalTrash;
            countText.text = collectedTrash + " / " + totalTrash;
        }
    }
}
