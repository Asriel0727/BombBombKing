using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankCheck : MonoBehaviour
{
    public CreateFire create;
    private bool bomb = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bomb"))
        {
            bomb = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            bomb = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            BombCheck(bomb, collision);
        }
    }
    public void BombCheck(bool bomb, Collider2D collision)
    {
        if(bomb)
        {
            float x = collision.transform.position.x;
            float y = collision.transform.position.y;
            int j = 1;
            StartCoroutine(create.SideFire(x, y, j));
        }
    }
}
