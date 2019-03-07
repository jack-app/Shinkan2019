using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moe2D : MonoBehaviour {

    public Sprite sprite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}
