using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour {

    public static Vector3 pr;
    public static float prr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pr = transform.position;
        prr = pr.x * pr.x + pr.z * pr.z;
	}
}
