using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireController : MonoBehaviour
{
    private Collider2D fireTrgger;

    private Image image;
    void Start()
    {
        fireTrgger = this.gameObject.GetComponent<Collider2D>();
    }

    void Update()
    {
        Invoke("DestroyPrefab", 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }

    void DestroyPrefab()
    {
        Destroy(gameObject);
    }
}
