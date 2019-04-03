using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeoutput : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text ="あなたは"+(int)Timekeepr.tmpTime+"秒生き延びました";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
