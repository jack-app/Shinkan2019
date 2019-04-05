using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDraSpon : MonoBehaviour {

    public GameObject flydra;
    GameObject player;
    // Use this for initialization
    void Start () {
        if (Bullet_easy.bullet_number != 1)
        {
        player = GameObject.FindGameObjectWithTag("Player");
        Invoke("Appear", 10);
        Invoke("Appear", 30);

        }
 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Appear()
    { Vector3 a = player.transform.position;
        a.x = a.x * 0.9f;a.z = a.z * 0.9f;
        a.y += 20;
        Instantiate(flydra, a, Quaternion.identity);
    }
}
