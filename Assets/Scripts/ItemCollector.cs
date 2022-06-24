using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int kiwis = 0;
    [SerializeField] TextMeshProUGUI textMesh;

    [SerializeField] private AudioSource recogerObjeto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("kiwi"))
        {
            recogerObjeto.Play();
            Destroy(collision.gameObject);
            kiwis++;   
            textMesh.text = "Kiwis: " + kiwis;
        }
    }
}
