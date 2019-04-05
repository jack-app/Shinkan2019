using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
