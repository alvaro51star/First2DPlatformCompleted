using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBala : MonoBehaviour
{

    private float moveSpeed = 5f;
    [SerializeField] private int direccion = -1;

    private void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * direccion * Time.deltaTime, transform.position.y);
        Destroy(gameObject, 1.9f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }

}
