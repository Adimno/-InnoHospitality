using System.Collections.Generic;
using UnityEngine;

public class DirtyUtensilsAdder : MonoBehaviour
{
    private HashSet<GameObject> dirtyObjectsInTrigger = new HashSet<GameObject>();

    [SerializeField] private GameObject planeObject;
    
    private Renderer planeRenderer;
    private bool doneTriggered = false;
    public S2CanvasManager canvas;
    public TotalPoints points;
    public TotalProgress progress;
    public S2IconLogic icon;
    public AudioSource correct;

    private void Start()
    {
        if (planeObject != null)
        {
            planeRenderer = planeObject.GetComponent<Renderer>();
        }
        else
        {
            Debug.LogWarning("Plane Object not assigned!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DirtyUtensils"))
        {
            if (dirtyObjectsInTrigger.Add(other.gameObject)) // Only adds if not already present
            {
                Debug.Log("Added: " + other.name + " | Count: " + dirtyObjectsInTrigger.Count);
            }

            if (dirtyObjectsInTrigger.Count == 7 && !doneTriggered)
            {
                Debug.Log("Done");
                canvas.DCleanDirtyShow();
                progress.IncrementProgress(8.33f);
                points.IncrementPoints(10);
                icon.PreClean1Icon();
                correct.Play();

                if (planeRenderer != null)
                {
                    // Set the color to green with alpha 64 (out of 255)
                    Material mat = planeRenderer.material;
                    Color greenWithAlpha = new Color(0f, 1f, 0f, 64f / 255f); // Green with alpha 64
                    mat.color = greenWithAlpha;

                    // Ensure the material uses transparent rendering
                    mat.SetFloat("_Mode", 3); // 3 = Transparent
                    mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                    mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                    mat.SetInt("_ZWrite", 0);
                    mat.DisableKeyword("_ALPHATEST_ON");
                    mat.EnableKeyword("_ALPHABLEND_ON");
                    mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
                    mat.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                }
                doneTriggered = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DirtyUtensils"))
        {
            if (dirtyObjectsInTrigger.Remove(other.gameObject))
            {
                Debug.Log("Removed: " + other.name + " | Count: " + dirtyObjectsInTrigger.Count);
            }
        }
    }
}
