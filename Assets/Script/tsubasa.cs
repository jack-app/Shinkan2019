using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tsubasa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Beam>().enabled = true;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
