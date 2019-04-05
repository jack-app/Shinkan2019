using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSplash : MonoBehaviour {

    public GameObject bul;
    public float interval;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Bull", 0.1f, interval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Bull()
    {
        Vector3 a = new Vector3(-1 + Random.value * 2, Random.value * 10, -1 + Random.value * 2);
        Instantiate(bul, a,Quaternion.identity);
    }
}
