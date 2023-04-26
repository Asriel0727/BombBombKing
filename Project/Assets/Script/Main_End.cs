using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main_End : MonoBehaviour
{
    [SerializeField]
    private Image btn_Menu;
    [SerializeField]
    private Text btn_MenuText;
    [SerializeField]
    private Text gameEnd1;

    // Start is called before the first frame update
    void Start()
    {
        if (HPboard.whoWin == 0)
        {
            gameEnd1.text = "遊戲結束";
        }
        if (HPboard.whoWin == 1)
        {
            gameEnd1.text = "玩家2獲勝";
        }
        if (HPboard.whoWin == 2)
        {
            gameEnd1.text = "玩家1獲勝";
        }
        btn_MenuText.text = ("點擊返回菜單");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Btn_StartToGame();
        }
    }
    public void Btn_StartToGame()
    {
        btn_Menu.color = new Color(0.9f, 0.9f, 0.9f);
        SceneManager.LoadScene(0);
    }
}
