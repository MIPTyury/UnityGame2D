using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [Header("Animation settings")]
    private Animator animator;
    
    private bool facingRight = true;

    [SerializeField] private int _entityMaxHealth;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    
    private void Flip()
    {
        gameObject.transform.Rotate(0, 180, 0, Space.Self);

        facingRight = !facingRight;
    }

    public void TrueFlip(Rigidbody2D rb)
    {
        if (rb.velocity.x < 0 && facingRight)
            Flip();
        if (rb.velocity.x > 0 && !facingRight)
            Flip();
    }

    public int GetEntityMaxHealth()
    {
        return _entityMaxHealth;
    }
}
