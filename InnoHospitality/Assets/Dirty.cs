using UnityEngine;

public class Dirty : MonoBehaviour
{
    public GameObject dirtyObject;
    public GameObject lotion;
    public int DirtyIndex;
    public DirtyChecker checker;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the lotion collided with this object
        if ((other.gameObject == lotion && this.gameObject == dirtyObject) ||
            (other.gameObject == dirtyObject && this.gameObject == lotion))
        {
            dirtyObject.SetActive(false);
            lotion.SetActive(false);
            checker.SetItemPicked(DirtyIndex);
        }
    }
}
