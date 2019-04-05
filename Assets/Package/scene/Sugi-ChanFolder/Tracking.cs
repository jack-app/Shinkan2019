using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour {

    GameObject pl;
    public float speed;
    Vector3 drc;
	// Use this for initialization
	void Start () {
        pl = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        float lim =Mathf.Sqrt( transform.position.x * transform.position.x + transform.position.z * transform.position.z);
        if (lim < 30)
        {
            Vector3 plp = pl.transform.position;
            Vector3 enp = gameObject.transform.position;
            float x = plp.x - enp.x;
            float y = plp.y - enp.y;
            float z = plp.z - enp.z;
            float xyz = Mathf.Sqrt(x * x+ y * y+ z * z);
            drc = new Vector3(x*speed/xyz,y*speed/xyz,z*speed/xyz);
            transform.Translate(drc,Space.World);

        }
        else
        {
            transform.Translate(drc,Space.World);
        }
	}
}
