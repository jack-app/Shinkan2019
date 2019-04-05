using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zokin : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 5);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GameMaster.GameOver();
        }
    }
}
