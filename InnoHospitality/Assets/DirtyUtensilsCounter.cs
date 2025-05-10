using System.Collections.Generic;
using UnityEngine;

public class DirtyUtensilsCounter : MonoBehaviour
{
    private HashSet<GameObject> dirtyObjectsInTrigger = new HashSet<GameObject>();

    [SerializeField] private GameObject planeObject;
    private Renderer planeRenderer;
    private bool colorChanged = false;

    private void Start()
    {
        if (planeObject != null)
        {
            planeRenderer = planeObject.GetComponent<Renderer>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DirtyUtensils"))
        {
            dirtyObjectsInTrigger.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DirtyUtensils"))
        {
            dirtyObjectsInTrigger.Remove(other.gameObject);

            if (dirtyObjectsInTrigger.Count == 0 && !colorChanged)
            {
                Debug.Log("Done");

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

                    colorChanged = true;
                }
            }
        }
    }
}
