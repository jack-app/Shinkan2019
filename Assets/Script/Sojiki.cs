using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sojiki : MonoBehaviour
{
    private GameObject Player;
    public float Speed;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GameMaster.GameOver();
        }
    }

    private void Update()
    {
        /*
        if ((gameObject.transform.position - Player.transform.position).magnitude < 3)
        {
            Player.GetComponent<Rigidbody2D>().AddForce((gameObject.transform.position - Player.transform.position) * Speed);
        }
        */
        Player.GetComponent<Rigidbody2D>().AddForce((gameObject.transform.position - Player.transform.position) * Speed);
    }
}
