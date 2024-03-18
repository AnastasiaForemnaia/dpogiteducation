using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public Animator animator;

    private void OnCollisionEnter(Collision collision)
    {
        animator.Play(collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("Empty");
    }
}
