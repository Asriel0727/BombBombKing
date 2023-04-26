using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    void Update()
    {
        Invoke("DestroyPrefab", 1.6f);
    }

    void DestroyPrefab()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fire"))
        {
            Invoke("DestroyPrefab", 0.5f);
        }
    }
}
