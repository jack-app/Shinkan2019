using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScore : MonoBehaviour
{
    public Text a;
    public Text b;
    // Start is called before the first frame update
    void Start()
    {
        Scorescript.tani = Scorescript.tani / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Scorescript.tani >=10000 )
        {
            b.text = "卒業!";
        }
        else if(Scorescript.tani >= 5000)
        {
            b.text = "留年";
        }
        else
        {
            b.text = "ニート...";
        }
        a.text = "単位は" + Scorescript.tani + "です！";
    }
}
