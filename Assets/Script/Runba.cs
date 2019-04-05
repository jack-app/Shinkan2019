using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runba : Enemy
{
    private GameObject Player;
    public float Speed = 5;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if (Player.transform.position.x < transform.position.x)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * Speed + Vector2.down;
        }else{
            GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed + Vector2.down;
        }
    }
}
