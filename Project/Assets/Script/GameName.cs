using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameName : MonoBehaviour
{
    [SerializeField]
    private Text gameName;
    // Start is called before the first frame update
    void Start()
    {
        gameName.text = "抱爆亡";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
