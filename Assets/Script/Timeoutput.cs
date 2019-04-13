using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeoutput : MonoBehaviour
{
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "あなたは" + (int)Timer.time + "秒生き延びました";
    }
}
