﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemySgchan3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //衝突の法線で上からの接触とそれ以外を分けています
            if (collision.contacts[0].normal == Vector2.down)
            {
                GameMasterSgchan3.Clear();
                Destroy(gameObject);
            }
            else
            {
                GameMasterSgchan3.GameOver();
            }
        }

    }
}
