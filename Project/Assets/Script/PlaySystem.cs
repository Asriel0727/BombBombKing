using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySystem : MonoBehaviour
{
    public Image p1image;

    public Image p2image;

    public PlayerAction action;

    static PlaySystem obj = null;

    public static int whoWin = 0;
    public static PlaySystem Instance
    {
        get
        {
            if (obj == null)
            {
                obj = new PlaySystem();
            }
            return obj;
        }
    }

    public Sprite[] image;

    public GameObject p1actor;

    public GameObject p2actor;

    void FixedUpdate()
    {
        action.MovePlayer(p1image, p2image);
    }

    void Start()
    {
        InitWay();

        p1image.transform.localScale = new Vector3(-1, 1, 1);

        
        for (int i = 0 ;i < 6; i++)
        {
            if (ButtonNum.select1 == i)
            {
                Debug.Log(i);
                p1actor.GetComponent<Image>().sprite = image[i];
            }
            if (ButtonNum.select2 == i)
            {
                Debug.Log(i);
                p2actor.GetComponent<Image>().sprite = image[i];
            } 
        }
    }

    private void InitWay()
    {
        p1image.transform.localScale = new Vector3(-1, 1, 1);
        GameObject child = p1image.transform.GetChild(0).gameObject;
        child.transform.localScale = new Vector3(-1, 1, 1);
    }

}
