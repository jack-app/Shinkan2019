using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mkmk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 0, 0.3f));
        if (transform.position.z >300)
        {
            Destroy(gameObject);
        }
	}
}
