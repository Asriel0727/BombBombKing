using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class btn_NewHand : MonoBehaviour
{
    [SerializeField]
    private Text btn_Text;
    public GameObject sound1;
    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        btn_Text.text = "操作教學(T)";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toTeaching()
    {
        open = !open;
        sound1.gameObject.SetActive(open);
        Invoke("openSound1", 0.4f);
        SceneManager.LoadScene(3);
    }
    private void openSound1()
    {
        open = !open;
        sound1.gameObject.SetActive(open);
    }
}
