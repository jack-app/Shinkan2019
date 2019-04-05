using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KankakuDeDasu : MonoBehaviour {

    public GameObject dasumono;
    public float kankaku;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spon", 0.1f, kankaku);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spon()
    {
        Instantiate(dasumono, transform.position, Quaternion.identity);
    }
}
