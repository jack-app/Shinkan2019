using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTTT : MonoBehaviour {

    public float x;
    public float y;
    public float z;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x = transform.rotation.eulerAngles.x;
        y = transform.rotation.eulerAngles.y;
        z = transform.rotation.eulerAngles.z;
        
    }
}
