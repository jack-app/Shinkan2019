using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger : MonoBehaviour {

    public float t;
    Vector3 size;
	// Use this for initialization
	void Start () {
        size = 1f * Vector3.one;
	}
	
	// Update is called once per frame
	void Update () {
        size = size * t;
        transform.localScale = size;
	}
}
