using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [Header("Animation settings")]
    public Animator animator;
    private bool facingRight = true;

    private void Update()
    {
        animator = GetComponent<Animator>();
    }
    private void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

    public void TrueFlip(Rigidbody2D rb)
    {
        if (rb.velocity.x < 0 && facingRight)
            Flip();
        if (rb.velocity.x > 0 && !facingRight)
            Flip();
    }
}
