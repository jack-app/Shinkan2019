using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorescript : MonoBehaviour
{
    public static int tani;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        tani =  0;
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "単位:"+tani+"";
    }
}
