using UnityEngine;

public class CustomerWalkToTable : MonoBehaviour
{
    public Animator animator; // Assign in the Inspector
    public Transform target;  // Assign the table GameObject here
    public float speed = 1f;

    public bool isWalking = false;

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
            if (animator == null)
            {
                Debug.LogError("Animator component is missing!");
            }
        }

        if (target == null)
        {
            Debug.LogError("Target is not assigned!");
        }
    }

    void Update()
    {
        if (isWalking)
        {
            MoveTowardsTarget();
        }
    }

    public void WalkToTable()
    {
        if (target == null || animator == null) return;

        isWalking = true;
        ResetTriggers();
        animator.SetTrigger("walk"); // Start walking animation
        Debug.Log("Walking animation triggered");
    }

    public void StartWalking()
    {
        // Public method to set isWalking to true
        isWalking = true;
        ResetTriggers();
        animator.SetTrigger("walk");
        Debug.Log("Start walking triggered from another script");
    }

    private void MoveTowardsTarget()
    {
        if (target == null) return;

        // Face the target
        Vector3 direction = (target.position - transform.position).normalized;
        if (direction.magnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        // Move towards the target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Continue walking animation while moving
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("walk"))
        {
            animator.SetTrigger("walk");
        }

        // Stop walking if close enough to the target
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            StopWalking();
        }
    }

    private void StopWalking()
    {
        isWalking = false;
        ResetTriggers();
        animator.SetTrigger("idle"); // Switch to idle animation
        Debug.Log("Idle animation triggered");
    }

    private void ResetTriggers()
    {
        animator.ResetTrigger("walk");
        animator.ResetTrigger("idle");
    }
}
