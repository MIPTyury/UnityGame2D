using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float HorizontalSpeed = 0;
    private float VerticalSpeed = 0;
    [SerializeField] private float speed = 5;


    [Header("Animation settings")]
    public Animator animator;
    
    private bool facingRight = true;
    
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        SetZeroPos();
    }

    // Update is called once per frame
    private void Update()
    {



    }
    private void FixedUpdate() {
        Run();

        animator.SetFloat("IsMoving", Math.Abs(HorizontalSpeed) + Math.Abs(VerticalSpeed));
    }

    private void Run()
    {
        HorizontalSpeed = Input.GetAxisRaw("Horizontal") * speed;
        VerticalSpeed = Input.GetAxisRaw("Vertical") * speed;
        Vector2 TargetVelocity = new Vector2(HorizontalSpeed, VerticalSpeed);
        rb.velocity = TargetVelocity.normalized * speed;

        if (rb.velocity.x < 0 && facingRight)
            Flip();
        if (rb.velocity.x > 0 && !facingRight)
            Flip();
    }

    private void SetZeroPos()
    {
        transform.position = Vector3.MoveTowards(transform.position,Vector3.zero, transform.position.magnitude);
    }

    private void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}