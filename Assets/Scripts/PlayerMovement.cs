using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 5;
    
    private bool facingRight = true;
    
    // Start is called before the first frame update
    private void Awake()
    {
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

        if (dir.x < 0 && facingRight)
            Flip();
        if (dir.x > 0 && !facingRight)
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
