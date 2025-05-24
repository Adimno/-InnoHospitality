using UnityEngine;
using UnityEngine.Events;

public class PlayerCutSceneCollider : MonoBehaviour
{
    public GameObject Player;
    public GameObject ColliderToDisable;
    public UnityEvent onPlayerEnter; // Assign any public void method from CutSceneCanvasManager here

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && !hasTriggered)
        {
            if (ColliderToDisable != null)
                ColliderToDisable.SetActive(false);

            hasTriggered = true;
            onPlayerEnter?.Invoke();
        }
    }
}
