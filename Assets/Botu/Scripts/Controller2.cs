using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour {

    new Rigidbody2D rigidbody;
    public bool onground;
    public float speed;
    public float jump;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        if (onground)
        {
            if (Input.GetKey(KeyCode.Space))
            {
            rigidbody.AddForce(new Vector2(0,jump));
                onground = false;
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && rigidbody.velocity.y <= 0)
        {
            onground = true;
           rigidbody.velocity = Vector2.zero;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && rigidbody.velocity.y <= 0)
        {
            onground = true;
           // rigidbody.velocity = Vector2.zero;
        }
    }
}
