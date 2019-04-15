using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowMan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "fire")
        {
            transform.localScale -= new Vector3(0.5f, 0.5f, 0);
        }
    }
}
