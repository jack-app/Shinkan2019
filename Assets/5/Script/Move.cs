using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Vector3[] destinationpositions;
    int destinationnumber=0;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, destinationpositions[destinationnumber],speed*Time.deltaTime);
        if (transform.position == destinationpositions[destinationnumber])
        {
            destinationnumber = (destinationnumber + 1) % destinationpositions.Length;
        }

   
	}
}
