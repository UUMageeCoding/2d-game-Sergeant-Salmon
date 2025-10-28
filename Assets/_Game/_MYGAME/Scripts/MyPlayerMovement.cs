using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class MyPlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    public Animator myanim;
    public int facingDirection = 1;

    //FixedUpdate is called 50x per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0 && transform.localScale.x < 0 ||
           horizontal < 0 && transform.localScale.x > 0)
        {
            Flip();
        }

        myanim.SetFloat("Horizontal", Mathf.Abs(horizontal));
        myanim.SetFloat("Vertical", Mathf.Abs(vertical));

        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }
    

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
