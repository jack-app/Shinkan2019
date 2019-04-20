using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    BoxCollider2D box;
    private void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Controller>().JumpOnEnemy();
            //衝突の法線で上からの接触とそれ以外を分けています
            if (collision.GetContact(0).normal.y < 0)
            {

                Destroy(gameObject);
            }
            else
            {
                var direction = collision.transform.position - transform.position;
                if ((Mathf.Sign(direction.x) == transform.localScale.x && direction.y > 1) || (Mathf.Sign(direction.x) == -transform.localScale.x && direction.y > 2.7f))
                {
                    var velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
                    print(velocity + " : " + velocity.normalized);
                    if (velocity.y < 25)
                    {
                        Destroy(gameObject);
                    }
                    else
                    {
                        box.enabled = false;
                        Invoke("Revive", 0.3f);
                    }

                }
                else
                {
                    GameMaster.GameOver();
                }


            }


        }

    }

    void Revive()
    {
        box.enabled = true;
    }


}
