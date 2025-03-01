using UnityEngine;
using System.Collections;

public class CustomerWalkToTable : MonoBehaviour
{
    public Animator animator; // Drag and drop the Animator in the Inspector
    public Transform target; // Assign the table GameObject here
    public float speed = 2f;
    public bool isWalking = false;

    void Update()
    {
        if (isWalking)
        {
            MoveTowardsTarget();
        }
    }

    public void WalkToTable()
    {
        if (target != null)
        {
            isWalking = true;
            ResetTriggers();
            animator.SetTrigger("walk");
            Debug.Log("Walking animation triggered");
        }
    }

    private void MoveTowardsTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        WalkToTable();
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            StopWalking();
        }
    }

    private void StopWalking()
    {
        isWalking = false;
        ResetTriggers();
        animator.SetTrigger("idle");
        Debug.Log("Idle animation triggered");
    }

    private void ResetTriggers()
    {
        animator.ResetTrigger("walk");
        animator.ResetTrigger("idle");
    }
}