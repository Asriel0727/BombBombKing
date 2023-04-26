using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_Start : MonoBehaviour
{
    [SerializeField]
    private Image btn_Start;
    [SerializeField]
    private Image btn_Teach;
    [SerializeField]
    private Image openEye;
    [SerializeField]
    private float RGBA_a_count=0.005f;
    public GameObject sound1;
    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Btn_StartToGame();
        }
        if (openEye.color.a > 0)
        {
            openEye.color -= new Color(0,0,0, RGBA_a_count);
        }
        if (Input.GetKey(KeyCode.T))
        {
            btn_Teach.color = new Color(0.9f, 0.9f, 0.9f);
            open = !open;
            sound1.gameObject.SetActive(open);
            Invoke("openSound1", 0.4f);
            SceneManager.LoadScene(3);
        }
    }
    public void Btn_StartToGame()
    {
        btn_Start.color = new Color(0.9f, 0.9f, 0.9f);
        Time.timeScale = 1;
        open = !open;
        sound1.gameObject.SetActive(open);
        Invoke("openSound1", 0.4f);
        SceneManager.LoadScene(1);
    }
    private void openSound1()
    {
        open = !open;
        sound1.gameObject.SetActive(open);
    }

}
