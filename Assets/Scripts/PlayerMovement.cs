using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 5;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        SetZeroPos();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            Run();
    }

    private void Run()
    {
        Vector3 dir  = transform.right * Input.GetAxis("Horizontal") + transform.up * Input.GetAxis("Vertical");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed*Time.deltaTime);

        sprite.flipX = dir.x < 0;
    }

    private void SetZeroPos()
    {
        transform.position = Vector3.MoveTowards(transform.position,Vector3.zero, transform.position.magnitude);
    }
}
