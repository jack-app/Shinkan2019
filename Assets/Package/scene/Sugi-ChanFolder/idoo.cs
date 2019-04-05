using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idoo : MonoBehaviour {

    public float x;
    public float y;
    public float z;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(x, y, z), Space.Self);
    }
}
