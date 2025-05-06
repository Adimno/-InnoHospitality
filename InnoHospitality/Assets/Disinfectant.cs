using UnityEngine;

public class Disinfectant : MonoBehaviour
{
    public GameObject Cap, Rag, lotion;

    private void OnTriggerEnter(Collider other)
    {
        // Check if Cap collided with Rag
        if ((other.gameObject == Cap && this.gameObject == Rag) ||
            (other.gameObject == Rag && this.gameObject == Cap))
        {
            lotion.SetActive(true);
        }
    }
}
