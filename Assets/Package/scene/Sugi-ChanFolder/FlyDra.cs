using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDra : MonoBehaviour {

    GameObject pl;
    GameObject en;
    bool r = false;
    public float speed;
	// Use this for initialization
	void Start () {
        pl = GameObject.FindGameObjectWithTag("Player");
        en = GameObject.FindGameObjectWithTag("Enemy");
        transform.Rotate(pl.transform.rotation.eulerAngles);
        

	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > -1)
        {
            transform.Translate(new Vector3(0, -0.03f, 0));
        }
        if (r)
        {
            transform.RotateAround(en.transform.position,Vector3.up,speed);
        }
       

	}
    void Rot()
    {
        r = true;
    }
   

}
