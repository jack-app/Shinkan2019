using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {

    new public Rigidbody2D rigidbody;
    public float maxspeed;              //最高速度
    public float accelaration;          //加速度
    public float jump;                  //ジャンプの高さ(この値を2倍にすると高さは4倍になります)
    public bool onground;               //接地判定用のフラグ
    public float skydeceleration;       //空中での減速率
    public float grounddeceleration;    //接地時の減速率

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {

        HorizontalMove();   //横方向の移動をします
        Jump();             //ジャンプします
        Deceleration();     //ジャンプ中の減速をします.
        FallDeathJudge();   //落下死の判定をします
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
       
        if (collision.transform.tag == "Ground" )
        {
            //接地時に法線が上を向いている & 速度が下方向のときにフラグを真に
            var nor = collision.contacts[1].normal;
            if (Mathf.Abs(nor.x) < Mathf.Abs(nor.y) && nor.y > 0 && rigidbody.velocity.y <= 0)
            {
                onground = true;
            }
            
        }
    }
    //地面から離れたらフラグを偽に
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            onground = false;
        }
    }

    void HorizontalMove()
    {
        //速度がmaxspeedより小さいときに力を加える
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
        if (Input.GetKey(KeyCode.Space) && onground)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
            rigidbody.AddForce(new Vector2(0, jump));
            onground = false;
        }
    }

    void Deceleration()
    {
        //方向ボタンが何も押されていないときに減速します

        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            if (onground)
            {
                rigidbody.velocity = new Vector2(rigidbody.velocity.x * grounddeceleration, rigidbody.velocity.y);
            }
            else
            {
                rigidbody.velocity = new Vector2(rigidbody.velocity.x * skydeceleration, rigidbody.velocity.y);
            }

            
        }
    }

    void FallDeathJudge()
    {
        if (transform.position.y < -7)
        {
            GM.GameOver();
        }
    }

}
