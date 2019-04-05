using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oooo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("OOO", 1.7f);
	}
	
	// Update is called once per frame
	void OOO () {
        SceneManager.LoadScene("Start_air");
	}
}
