using UnityEngine;

public class DirtyS1 : MonoBehaviour
{
    public GameObject dirtyObject;
    public GameObject lotion;
    public int DirtyIndex;
    public DirtyCheckerS1 checker;

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
