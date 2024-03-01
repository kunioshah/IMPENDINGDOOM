using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;

    private float moveSpeed;
    public float rotateSpeed;
    private float x;
    private float y;
     
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMover();
    }

    void PlayerMover() {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        Vector2 movementDirection = new Vector2(x, y);

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            rb.AddForce(new Vector2(x * moveSpeed, 0f), ForceMode2D.Impulse);
        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            rb.AddForce(new Vector2(0f, y * moveSpeed), ForceMode2D.Impulse);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if (movementDirection != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        }
            
    }

}
