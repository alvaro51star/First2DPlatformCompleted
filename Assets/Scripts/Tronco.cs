using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tronco : MonoBehaviour
{
    [SerializeField] GameObject bala;
    [SerializeField] Transform posicionDisparo;
    [SerializeField] AudioSource shootSound;

    private void dispararBala()
    {
        shootSound.Play();
        GameObject newbullet= Instantiate(bala, posicionDisparo.position,Quaternion.identity);
    }
}
