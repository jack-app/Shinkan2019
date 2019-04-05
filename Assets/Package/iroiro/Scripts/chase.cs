using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {
    Vector3 go;
    GameObject aa;
    GameObject me;
    float time;
    public float a;
    
	// Use this for initialization
	void Start () {
        aa = GameObject.FindGameObjectWithTag("tamadashi");
        time = aa.GetComponent<Tekinotama>().Sokudo;
        me = aa.GetComponent<Tekinotama>().Jibun;
        go = new Vector3((me.transform.position.x - transform.position.x)*time/100, (me.transform.position.y - transform.position.y)*time/100, (me.transform.position.z - transform.position.z)*time/100);
        a = go.z;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(go,Space.World);
	}
}
