using UnityEngine;

public class CustomerAnimation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
        
    }

    public void Walk()
    {
        ResetTriggers();
        animator.SetTrigger("walk");
    }

    public void Idle()
    {
        ResetTriggers();
        animator.SetTrigger("idle");
    }

    private void ResetTriggers()
    {
        animator.ResetTrigger("walk");
        animator.ResetTrigger("idle");
    }
}
