using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Vector3 position;
    public Vector3 destinationvector;
    public  float speed;
    private Vector3 unitdirection;
    private float directionscale;
    private float distance;
    private int b=1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
      
	}



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //上からの接触とそれ以外を別けています
            if (collision.contacts[0].normal == Vector2.down)
            {
                Destroy(gameObject);
            }
            else
            {
                GM.GameOver();
            }
        }
       
    }


}
