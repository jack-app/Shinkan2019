using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beamrefarense : MonoBehaviour
{
    public GameObject bomb;
    private Vector3 v;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "rock")
        {
            v = other.gameObject.GetComponent<Transform>().position;
            Destroy(other.gameObject);
            Instantiate(bomb,v,Quaternion.identity);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
