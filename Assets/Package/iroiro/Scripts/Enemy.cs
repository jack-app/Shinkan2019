using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int hp;


	void Start () {
        hp = 100;
   
    }

    void Update () {
		
	}
 void OnTriggerEnter(Collider other)
    {
        //色を変えたいときはこんな感じで
        GetComponent<Renderer>().material.color = new Color(1, 0, 0);

    }



}
