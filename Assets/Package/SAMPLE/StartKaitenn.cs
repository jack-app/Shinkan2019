using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartKaitenn : MonoBehaviour {

    public int x;
    public int y;
    public int z;
	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(x, y, z));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
