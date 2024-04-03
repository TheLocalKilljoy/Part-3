using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public Rigidbody2D rb;
    BoxCollider2D bc;

    public float speed = 5f;

    Vector2 move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        bc = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.deltaTime);
    }

    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }
}
