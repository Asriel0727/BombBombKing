using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectRole : MonoBehaviour
{
    private int select1;

    private int select2;

    public Text P1_Select;
    public Text P2_Select;

    private string[] roleName = { "睏寶","藍寶", "ㄚ肥", "猴子", "痞子妹", "囡囡" };

    public GameObject warning;

    bool p1checked;
    bool p2checked;

    // Start is called before the first frame update
    void Start()
    {
        UnSure();
    }

    // Update is called once per frame
    void Update()
    {
        select1 = ButtonNum.select1;
        select2 = ButtonNum.select2;

        if (select1 >= 0)
        {
            P1_Select.text = "玩家1角色:" + roleName[select1];
            
        }
        if (select2 >= 0)
        {
            P2_Select.text = "玩家2角色:" + roleName[select2];
        }
        
    }

    
    public void Sure()
    {
        Debug.Log(p1checked);
        Debug.Log(p2checked);

        p1checked = ButtonNum.p1checked;
        p2checked = ButtonNum.p2checked;

        if (p1checked == true && p2checked == true)
        {
            SceneManager.LoadScene(2);
            warning.gameObject.SetActive(false);
        }
        else if (p1checked == false || p2checked == false)
        {
            warning.gameObject.SetActive(true);
        }
    }

    public void UnSure()
    {
        ButtonNum.p1checked = false;
        ButtonNum.select1 = -1;
        P1_Select.text = "玩家1選擇:";
        ButtonNum.p2checked = false;
        ButtonNum.select2 = -1;
        P2_Select.text = "玩家2選擇:";
        warning.gameObject.SetActive(false);
    }
}
