using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotRunE : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 pos = transform.position;
        Vector3 rot = transform.rotation.eulerAngles;
        if (pos.x == 0)
        {
            pos.x = 0.01f;
        }
        float aa = Mathf.Asin(pos.x / Mathf.Sqrt(pos.x * pos.x + pos.z * pos.z));
        float aaa = aa * 180 / Mathf.PI;
        if (pos.z >= 0)
        {
            rot.y -= aaa;

        }
        else
        {
            rot.y -= 180 - aaa;
        }
        transform.Rotate(rot);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
