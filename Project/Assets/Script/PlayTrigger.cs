using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayTrigger : MonoBehaviour
{
    public GameObject bombPrefab;

    public Canvas canvas;

    public CreateFire fire;

    public GameObject boomSound;

    public PlayerAction action;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Untagged"))
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Joystick1Button0)) && gameObject.tag == "Player1" && action.stop == 1)
            {
                BombCreate(collision);
            }
            if((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.Joystick1Button1)) && gameObject.tag == "Player2" && action.stop == 1)
            {
                BombCreate(collision);
            }
        }
    }

    public void BombSound()
    {
        GameObject boom = Instantiate(boomSound, new Vector3(0, 0, 0), Quaternion.identity);
        boom.transform.SetParent(canvas.transform, false);
    }

    public void BombCreate(Collider2D collision)
    {
        GameObject player = gameObject;
        float x = collision.transform.position.x;
        float y = collision.transform.position.y;
        GameObject bomb = Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt(y), 0), bombPrefab.transform.rotation);
        bomb.transform.SetParent(canvas.transform, false);
        StartCoroutine(fire.PlayerCreateFire(collision, player));
        Invoke("BombSound", 1.5f);
    }
}
