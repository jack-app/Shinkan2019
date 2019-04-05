using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterMode : MonoBehaviour {

    public int modenumber;
	// Use this for initialization
	void Start () {
        if (Bullet_easy.bullet_number ==0)
        {
            Bullet_easy.bullet_number = modenumber;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
