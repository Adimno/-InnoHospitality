using UnityEngine;

public class ToolDetector : MonoBehaviour
{
    public GameObject[] gameObjectsToCheck;
    public Tools checker;
    public int ToolsIndex;

    private bool[] previousStates;

    void Start()
    {
        // Initialize the previousStates array based on initial activeSelf states
        previousStates = new bool[gameObjectsToCheck.Length];
        for (int i = 0; i < gameObjectsToCheck.Length; i++)
        {
            previousStates[i] = gameObjectsToCheck[i].activeSelf;
        }
    }

    void Update()
    {
        for (int i = 0; i < gameObjectsToCheck.Length; i++)
        {
            bool currentState = gameObjectsToCheck[i].activeSelf;
            if (currentState != previousStates[i])
            {
                // Only act if the state has changed
                if (!currentState)
                {
                    checker.SetItemPicked(ToolsIndex);
                }

                previousStates[i] = currentState;
            }
        }
    }
}
