using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.left * 40f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
