using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute_Main : MonoBehaviour
{
    [SerializeField]
    private Image btn_Mute;
    [SerializeField]
    private GameObject BGM;
    private bool muted = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (muted == true)
            {
                btn_Mute.color = new Color(1, 0, 0, 1f);
            }
            else
            {
                btn_Mute.color = new Color(1, 0, 0, 0.5f);
            }
            BGM.GetComponent<AudioSource>().mute = muted;
            muted = !muted;
        }
    }
    public void BGM_Mute()
    {
        if (muted == true)
        {
            btn_Mute.color = new Color(1, 0, 0, 1f);
        }
        else
        {
            btn_Mute.color = new Color(1, 0, 0, 0.5f);
        }
        BGM.GetComponent<AudioSource>().mute = muted;
        muted = !muted;
    }
}
