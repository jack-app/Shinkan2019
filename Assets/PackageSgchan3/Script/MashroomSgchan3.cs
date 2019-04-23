using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashroomSgchan3 : MonoBehaviour
{
    public float jump=10000;
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
        if (collision.gameObject.tag == "Player")
        {
            var normal= collision.GetContact(0).normal;
            collision.transform.GetComponent<Rigidbody2D>().AddForce(-normal * jump);
        }
    }
}
