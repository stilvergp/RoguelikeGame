using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public Vector2 moveDir;

    public float moveSpeed = 3f;

    private Transform player;
    private Animator animator;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
        animator = GetComponent<Animator>();

        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
    }

    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.magnitude);
    }
}
