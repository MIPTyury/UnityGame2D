using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementControlls : MonoBehaviour
{
    private Rigidbody2D rb;
    private float HorizontalSpeed = 0;
    private float VerticalSpeed = 0;
    [SerializeField] private float speed = 5;
    private Animator animator;

    private Entity entity;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        entity = GetComponent<Entity>();
    }

    // Update is called once per frame
    private void FixedUpdate() {
        Run();
    }
    
    private void Run()
    {
        if (entity) 
        {
            HorizontalSpeed = Input.GetAxisRaw("Horizontal") * speed;
            VerticalSpeed = Input.GetAxisRaw("Vertical") * speed;
            Vector2 TargetVelocity = new Vector2(HorizontalSpeed, VerticalSpeed);
            rb.velocity = TargetVelocity.normalized * speed;
            
            entity.TrueFlip(rb);
        }

        animator.SetFloat("IsMoving", Math.Abs(HorizontalSpeed) + Math.Abs(VerticalSpeed));
    }
}
