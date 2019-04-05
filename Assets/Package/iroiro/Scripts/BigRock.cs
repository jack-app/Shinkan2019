using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRock : MonoBehaviour {

    private Vector3 vec;
    Vector3 rot = new Vector3(1, 1, 1);
        // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {
        transform.Translate(0, 0, -0.3f, Space.World);
        if (transform.position.z < -11)
        {
            Destroy(gameObject);
        }
    }
}
