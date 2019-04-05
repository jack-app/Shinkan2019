using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mkmkrotate : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 y = player.transform.rotation.eulerAngles;
        y.y += 180;
        transform.Rotate(y);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 0, 0.1f));
       
    }
}
