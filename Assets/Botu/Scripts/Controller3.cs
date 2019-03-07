using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller3 : MonoBehaviour {

    public BoxCollider2D collider;
    Vector2 colliderscale;
    Rigidbody2D rigidbody;
    Vector3 velocity;
    public float speed;
    public float gravity;
    public float jump;
    public bool onground;
    float size;
    public float height;
    public float wide;
	// Use this for initialization
	void Start () {
        size = transform.localScale.x;
        colliderscale = collider.size*size;

       
	}
	
	// Update is called once per frame
	void Update () {
      
        
        velocity.y -= gravity * Time.deltaTime;
        velocity.x = speed*Input.GetAxis("Horizontal");
        Move();
        //接地判定
        //Onground();
        //ジャンプ判定
        if (onground)
        {


            if (Input.GetKey(KeyCode.Space))
            {
                velocity.y += jump;
                onground = false;
            }
        }
        //落下判定
        Fall();
    }

    void Onground()
    {
        onground = false;
        //BoxCastを飛ばした接地判定
        RaycastHit2D hit= Physics2D.BoxCast(transform.position, colliderscale, 0, Vector2.down,height*1.1f);
        if (hit)
        {

        if (hit.transform.tag=="Ground")
        {
                //ジャンプ前半では接地判定をとらないように
                if (velocity.y < 0)
                {
                    //設置地点に足をもってくるように調整
                    transform.position=new Vector3(transform.position.x,hit.point.y+height,0);
                    velocity.y = 0;
                    onground = true;
                }
           

        }

        }

    }

   void Move()
    {
        //まず移動ベクトルを垂直方向水平方向に分割
        var v = velocity * Time.deltaTime;
        var horizontal = new Vector3(v.x, 0);
        var vertical = new Vector3(0, v.y);
        float hori;
        float ver;
        if (Mathf.Abs(horizontal.x)<=wide)
        {
            hori = wide*1.1f;
        }
        else
        {
            hori = Mathf.Abs(horizontal.x)*1.1f;
        }
        if (0 >= vertical.y && Mathf.Abs(vertical.y) <= height*0.2f)
        {
            ver = height*0.22f;
        }
        else
        {
            ver =Mathf.Abs(vertical.y)*1.1f;
        }

        //それぞれBoxCastで衝突判定をとる
        RaycastHit2D hit1 = Physics2D.BoxCast(transform.position, colliderscale, 0, horizontal, hori);
        RaycastHit2D hit2 = Physics2D.BoxCast(transform.position, colliderscale, 0, vertical, ver);
        if (hit1)
        {


            if (hit1.point.x <= transform.position.x)
            {
                transform.position =new Vector3(hit1.point.x+wide,transform.position.y);
                velocity.x = 0;

            }
            else
            {
                transform.position = new Vector3(hit1.point.x - wide, transform.position.y);
                velocity.x = 0;
            }
        }
        else
        {
            transform.position += horizontal;
        }
        if (hit2)
        {
            if (hit2.point.y <= transform.position.y)
            {
                transform.position = new Vector3(transform.position.x,hit2.point.y+height);
                velocity.y = 0;
                onground = true;
            }
            else
            {
                transform.position = new Vector3(transform.position.x, hit2.point.y - height);
                velocity.y = 0;
            }
        }
        else
        {
            transform.position += vertical;
            onground = false;
        }
    }

    void Fall()
    {
        if (transform.position.y < -6)
        {
            GameSystem.GameOver();
        }
    }



/*
    private void OnDrawGizmos()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, colliderscale, 0, Vector2.down, height*1.1f);
        Gizmos.DrawWireCube(hit.point, colliderscale);
    }
  */  
}
