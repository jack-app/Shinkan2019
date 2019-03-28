using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timekeepr : MonoBehaviour
{
    static public double tmpTime = 0;
    public Text ttext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpTime += Time.deltaTime;
        ttext.text ="Time:" + (int)tmpTime;


    }
}
