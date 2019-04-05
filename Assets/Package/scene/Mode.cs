using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mode : MonoBehaviour {

    public Text text;
    string s;
	// Use this for initialization
	void Start () {
        switch (Bullet_easy.bullet_number)
        {
            case 1:s = "Easy";break;
            case 2:s = "Normal";break;
            case 3:s = "Hard";break;
            case 5:s = "Hell";break;
        }
        text.text = s;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
