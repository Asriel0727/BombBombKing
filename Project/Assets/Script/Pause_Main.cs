using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Main : MonoBehaviour
{
    public Button btn_Pause;
    public Text text_Pause;
    public Image Pause_window;
    public GameObject bgm;
    private bool isPause;
    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
        btn_Pause.onClick.AddListener(PauseGame);
        text_Pause.text = "—暫停遊戲—";
    }
    void PauseGame()
    {
        isPause = !isPause;
        if (isPause == true)
        {
            //btn_Pause.image.sprite = Resources.Load<Sprite>("Assets/Images/Button/play-buttton");
            btn_Pause.gameObject.SetActive(true);
            text_Pause.gameObject.SetActive(true);
            Pause_window.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            //btn_Pause.image.sprite = Resources.Load<Sprite>("Assets/Images/Button/Pause");
            Pause_window.gameObject.SetActive(false);
            text_Pause.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            PauseGame();
        }
    }
}
