using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public  class GameSystem : MonoBehaviour {

    public static bool clear;
    public GameObject cleartext;
    
	// Use this for initialization
	void Start () {
		
      clear = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (clear == true)
        {
            cleartext.SetActive(true);
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene("Scene2");
            }
        }
        
	}

    public static void Clear()
    {
        clear = true;
    }

    public static void GameOver()
    {
        if (!clear)
        {
            SceneManager.LoadScene("GameOver");

        }
    }

}
