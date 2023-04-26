using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level_choose : MonoBehaviour
{

    private static int numScene = 5;
    private static int maxNum = 6;
    private static int minNum = 5;
    [SerializeField]
    private GameObject Image_level;
    public Sprite scene_01;
    public Sprite scene_02;

    public GameObject sound1;
    public GameObject sound2;

    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        numScene = 5;
        Image_level.GetComponent<Image>().sprite = scene_01;
    }

    // Update is called once per frame
    void Update()
    {
        if (numScene == 5)
        {
            Image_level.GetComponent<Image>().sprite = scene_01;
        }
        if (numScene == 6)
        {
            Image_level.GetComponent<Image>().sprite = scene_02;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rightChange();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            leftChange();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            sure();
        }
    }
    public void rightChange()
    {
        open = !open;
        sound1.gameObject.SetActive(open);
        Invoke("openSound1", 0.3f);
        if (numScene < maxNum)
        {
            numScene += 1;
        }

    }
    public void leftChange()
    {
        open = !open;
        sound1.gameObject.SetActive(open);
        Invoke("openSound1", 0.3f);
        if (numScene > minNum)
        {
            numScene -= 1;
        }

    }
    public void sure()
    {
        open = !open;
        sound2.gameObject.SetActive(open);
        Invoke("openSound2", 0.4f);
        SceneManager.LoadScene(numScene);
    }
    private void openSound1()
    {
        open = !open;
        sound1.gameObject.SetActive(open);
    }
    private void openSound2()
    {
        open = !open;
        sound2.gameObject.SetActive(open);
    }
}
