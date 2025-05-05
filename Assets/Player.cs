using UnityEngine;
using System;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 coordinate;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        moveSpeed = 5f;
        coordinate = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            coordinate.y++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            coordinate.y--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            coordinate.x++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            coordinate.x--;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 7.9f;
        }
      


    }
    void FixedUpdate()
    {
        rb.linearVelocity = coordinate.normalized * moveSpeed;
    }
}
