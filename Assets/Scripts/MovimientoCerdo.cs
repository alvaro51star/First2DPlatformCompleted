using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCerdo : MonoBehaviour
{
    [SerializeField] private Transform destino1;
    [SerializeField] private Transform destino2;
    private SpriteRenderer spriteRenderer;
    private int horizontal = 1;
    [SerializeField] private float speed = 10f;

    

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = rb.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if(rb.velocity.x < 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;    
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("limit"))
        {
            horizontal *= -1;
        }
    }
}
