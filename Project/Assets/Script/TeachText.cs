using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeachText : MonoBehaviour
{
    [SerializeField]
    private Text P1;
    [SerializeField]
    private Text P2;
    [SerializeField]
    private Text Note;
    [SerializeField]
    private Text back;
    // Start is called before the first frame update
    void Start()
    {
        P1.text = "WASD操作上下左右" + "\n" + "空白鍵放炸彈";
        P2.text = "方向鍵操作上下左右" + "\n" + "右Control放炸彈";
        Note.text = "Backspace暫停遊戲" + "\n" + "\n" + "M鍵關閉背景音樂" + "\n" + "\n" + "按下esc返回主畫面";
        back.text = "返回主畫面";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void backMain()
    {
        SceneManager.LoadScene(0);
    }
}
