using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentPortal;

    [SerializeField] private AudioSource portalSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(currentPortal != null)
            {
                portalSound.Play();
                transform.position = currentPortal.GetComponent<Portal>().GetDestination().position;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            currentPortal = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            if(collision.gameObject == currentPortal)
            {
                currentPortal = null;
            }
        }
    }
}
