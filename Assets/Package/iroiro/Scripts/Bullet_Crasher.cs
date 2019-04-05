using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Crasher : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
