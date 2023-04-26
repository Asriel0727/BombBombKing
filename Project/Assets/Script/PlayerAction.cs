using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    Rigidbody2D rb1;

    Rigidbody2D rb2;

    private Vector2 velocity;

    private float speed1;

    private float speed2;

    public int stop = 1;

    public void MovePlayer(Image player1, Image player2)
    {
        rb1 = player1.GetComponent<Rigidbody2D>();
        rb2 = player2.GetComponent<Rigidbody2D>();

        speed1 = HPboard.player1.speed;
        speed2 = HPboard.player2.speed;

        //Debug.Log(speed1);
        //Debug.Log(speed2);

        //if(Input.GetAxis("Horizontal")>0)

        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0) 
        {
            velocity = new Vector2(speed1, 0);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime * stop);
            rb1.transform.localScale = new Vector3(-1, 1, 1);
            ChildrenChangedRight(rb1);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") < 0)
        {
            velocity = new Vector2(-speed1, 0);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime * stop);
            rb1.transform.localScale = new Vector3(1, 1, 1);
            ChildrenChangedLeft(rb1);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical") > 0)
        {
            velocity = new Vector2(0, speed1);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime * stop);

        }
        if (Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical") < 0)
        {
            velocity = new Vector2(0, -speed1);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime * stop);

        }


        if (Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal2") > 0)
        {
            velocity = new Vector2(speed2, 0);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime * stop);
            rb2.transform.localScale = new Vector3(-1, 1, 1);
            ChildrenChangedRight(rb2);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal2") < 0)
        {
            velocity = new Vector2(-speed2, 0);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime * stop);
            rb2.transform.localScale = new Vector3(1, 1, 1);
            ChildrenChangedLeft(rb2);


        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetAxis("Vertical2") > 0)
        {
            velocity = new Vector2(0, speed2);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime * stop);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetAxis("Vertical2") < 0)
        {
            velocity = new Vector2(0, -speed2);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime * stop);
        }

    }

    private void ChildrenChangedLeft(Rigidbody2D rigidbody)
    {
        GameObject child = rigidbody.transform.GetChild(0).gameObject;
        child.transform.localScale = new Vector3(1, 1, 1);
    }

    private void ChildrenChangedRight(Rigidbody2D rigidbody)
    {
        GameObject child = rigidbody.transform.GetChild(0).gameObject;
        child.transform.localScale = new Vector3(-1, 1, 1);
    }
}
