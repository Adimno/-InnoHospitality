using UnityEngine;

public class PlayerPortal : MonoBehaviour
{
    public GameObject player; // Assign your player GameObject here in the Inspector
    public string sceneToLoad = "Tutorial"; // Scene to load
    public SceneLoadingScript sceneLoader;  // Reference to the loader script

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            if (sceneLoader != null)
            {
                sceneLoader.StartCoroutine(sceneLoader.LoadScene(sceneToLoad));
            }
            else
            {
                Debug.LogError("SceneLoadingScript not assigned in PlayerPortal.");
            }
        }
    }
}
