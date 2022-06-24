using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    [SerializeField] private float bounce = 30f;
    private Animator animator;

    [SerializeField] private AudioSource trampolinSound;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            trampolinSound.Play();
            animator.SetBool("jump", true);
        }
    }

    private void TerminaAnimacion()
    {
        animator.SetBool("jump", false);
    }

    
}
