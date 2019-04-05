using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    private Vector3 vec;
    // Update is called once per frame
    private void Start()
    {
     
    }
    void Update()
    {
        transform.Translate(0, 0, -0.3f,Space.World);
        if (transform.position.z < -11)
        {
            Destroy(gameObject);
        }
    }
}
