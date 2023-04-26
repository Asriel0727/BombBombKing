using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNum : MonoBehaviour
{
    public static int select1 = 0;

    public static int select2 = 0;

    public int p1select;

    public int p2select;

    public static bool p1checked = false;

    public static bool p2checked = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selected()
    {
        if (p1checked == false)
        {
            select1 = p1select;
            p1checked = true;
            Debug.Log("p1checked:" + p1checked);
        }
        else if (p2checked == false)
        {
            select2 = p2select;
            p2checked = true;
            Debug.Log("p2checked:" + p2checked);
        }
    }
}
