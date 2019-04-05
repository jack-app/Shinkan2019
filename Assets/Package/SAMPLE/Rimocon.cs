using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rimocon : MonoBehaviour {
    public float sokudo;
 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, sokudo, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -sokudo, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(sokudo, 0, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-sokudo, 0, 0), Space.World);
        }

    }
}
