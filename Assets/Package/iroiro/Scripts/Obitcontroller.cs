using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obitcontroller : MonoBehaviour {

    public GameObject enemy;
    public float speed;
    float sp;
    int a = 10 ^ 40;
	// Use this for initialization
	void Start () {
        sp = speed / 3.14f;
	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(enemy.transform.position, new Vector3(0, 1, 0), -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(enemy.transform.position, new Vector3(0, 1, 0), speed);
        }
        if (Input.GetKey(KeyCode.UpArrow)&&transform.position.y<11)
        {
            transform.Translate(new Vector3(0, sp, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >0)
        {
            transform.Translate(new Vector3(0, -sp, 0));
        }
    }
}
