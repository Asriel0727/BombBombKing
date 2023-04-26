using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    private int seconds;

    private int min = 3;
    private int sec = 00;
    private int sec_start = 4;

    public TMP_Text timer;
    public TMP_Text time_Start;
    public GameObject time_Start_box;

    public PlayerAction action;


    void Start()
    {
        StartCoroutine(ActionCountdown());
    }

    IEnumerator ActionCountdown()
    {
        while (sec_start > 0)
        {
            sec_start--;
            if (sec_start > 0)
            {
                action.stop = 0;
                time_Start_box.SetActive(true);
                time_Start.text = sec_start.ToString();
                
            }
            else
            {
                action.stop = 1;
                time_Start_box.SetActive(false);
                StartCoroutine(Countdown());
            }
            yield return new WaitForSeconds(1);
        }

    }

    IEnumerator Countdown()
    {
        timer.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00"));
        seconds = (min * 60) + sec;
        while (seconds > 0)
        {
            yield return new WaitForSeconds(1);

            seconds--;

            sec--;

            if (sec < 0 && min > 0)
            {
                min -= 1;
                sec = 59;
            }
            else if (sec < 0 && min == 0)
            {
                sec = 0;
            }
            timer.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00"));
            
        }

        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
    void Update()
    {
        if (sec + min == 0)
        {
            SceneManager.LoadScene(4);
        }

    }
}
