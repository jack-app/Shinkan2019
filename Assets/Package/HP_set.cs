using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_set : MonoBehaviour {
    GameObject HP;

	// Use this for initialization
	void Start () {
        HP = GameObject.Find("HpBarCtrl");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Bullet)
    {
        
        if(Bullet.name!="Bullet")
        {Debug.Log("atari");
            HP.GetComponent<HpBarCtrl>()._hp -= 1;
            
        }
    }
}
