using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 12f;

    [SerializeField] private AudioSource killEnemySound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            killEnemySound.Play();
            Destroy(collision.gameObject);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
