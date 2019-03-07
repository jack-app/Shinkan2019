using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    new public Rigidbody2D rigidbody;
    public float maxspeed;
    public float accelaration;
    public float jump;
    public bool onground;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        HorizontalMove();
        Jump();
        Deceleration();

	}

    void HorizontalMove()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (rigidbody.velocity.x <= maxspeed)
            {
                rigidbody.AddForce(new Vector2(accelaration, 0));
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rigidbody.velocity.x >= -maxspeed)
            {
                rigidbody.AddForce(new Vector2(-accelaration, 0));
            }
        }
  
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space)&&onground)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
            rigidbody.AddForce(new Vector2(0, jump));
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        var nor = collision.contacts[1].normal;
        if (collision.transform.tag == "Ground" && Mathf.Abs(nor.x) < Mathf.Abs(nor.y)&&nor.y>0) 
        {
            onground = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            onground = false;
        }
    }

    void Deceleration()
    {
        if(!Input.GetKey(KeyCode.LeftArrow)&& !Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity=new Vector2(rigidbody.velocity.x*0.95f,rigidbody.velocity.y);
        }
    }
}
