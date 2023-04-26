using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPboard : MonoBehaviour
{
    public PlayerAttribute[] role = { new SleepBaby(), new BlueBaby(), new GreenBaby(), new MonkeyBaby(), new PurpleBaby(), new YellowBaby() };
    
    public static PlayerAttribute player1;
    public static PlayerAttribute player2;

    public Text player1Hp;
    public Text player2Hp;

    public Image image;

    public static int whoWin = 0;
    public bool cantouch = true;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            if (ButtonNum.select1 == i)
            {
                player1 = role[i];
                Debug.Log(player1);
            }
            if (ButtonNum.select2 == i)
            {
                player2 = role[i];
                Debug.Log(player2);
            }
        }
        player1.InitAll();
        //Debug.Log(player1.speed);

        player2.InitAll();
        //Debug.Log(player2.speed);

        player1Hp.text = "玩家1血量:" + player1.playerLife.ToString();
        player2Hp.text = "玩家2血量:" + player2.playerLife.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            if (gameObject.CompareTag("Player1"))
            {
                if (!cantouch)
                {
                    return;
                }
                else
                {
                    cantouch = false;
                    player1.playerLife -= 1;

                    StartCoroutine(Hurted());

                    player1Hp.text = "玩家1血量:" + player1.playerLife.ToString();
                    Invoke("InitTouch", 3f);
                    if (player1.playerLife == 0)
                    {
                        whoWin = 1;
                        SceneManager.LoadScene(4);
                    }
                }
            }
            if (gameObject.CompareTag("Player2"))
            {
                if (!cantouch)
                {
                    return;
                }
                else
                {
                    cantouch = false;
                    player2.playerLife -= 1;

                    StartCoroutine(Hurted());

                    player2Hp.text = "玩家2血量:" + player2.playerLife.ToString();
                    Invoke("InitTouch", 3f);
                    if (player2.playerLife == 0)
                    {
                        whoWin = 2;
                        SceneManager.LoadScene(4);
                    }
                }
            }
        }
    }
    private bool InitTouch()
    {
        cantouch = true;
        return cantouch;
    }

    public IEnumerator Hurted()
    {
        Debug.Log(image.color);
        image.color -= new Color(0, 0, 0, 0.4f);
        Debug.Log(image.color);
        yield return new WaitForSeconds(0.3f);
        image.color += new Color(0, 0, 0, 0.4f);

    }
}
