using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Winner : MonoBehaviour {

    int count = 60;
    public Text text;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Co", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        if (count == 0)
        {
            SceneManager.LoadScene("SSSSample");
        }
	}
    void Co()
    {
        count--;
        text.text = "" + count;

       
    }

}
