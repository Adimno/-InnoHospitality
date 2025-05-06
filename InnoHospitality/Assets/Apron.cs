using UnityEngine;

public class Apron : MonoBehaviour
{
    public GameObject targetObject; // Assign the specific GameObject in the Inspector
    public Tools checker;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            checker.SetItemPicked(3);
            targetObject.SetActive(false);
        }
    }
}
