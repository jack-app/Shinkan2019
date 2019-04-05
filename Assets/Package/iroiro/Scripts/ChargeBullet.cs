using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBullet : MonoBehaviour {

    public Text bullettext;
    public Text Bigbullettext;


    private void Start()
    {
        Variables.bulletnumber = 100;
        InvokeRepeating("Charge", 0, 0.1f);
    }
    // Update is called once per frame
    void Update ()
    {
        
        bullettext.text = "" + Variables.bulletnumber;
        Bigbullettext.text = "" + Variables.heavybulletcountor;
    }
    void Charge()
    {
        if (Variables.bulletnumber < 100)
        {
            Variables.bulletnumber++;
        }

    }
}
