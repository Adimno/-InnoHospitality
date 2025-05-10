using System.Collections.Generic;
using UnityEngine;

public class DirtyUtensilsCounter : MonoBehaviour
{
    private HashSet<GameObject> dirtyObjectsInTrigger = new HashSet<GameObject>();

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

            if (dirtyObjectsInTrigger.Count == 0)
            {
                Debug.Log("Done");
            }
        }
    }
}
