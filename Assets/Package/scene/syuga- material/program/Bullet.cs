using UnityEngine;

using System.Collections;

public class Bullet : MonoBehaviour
{

    float bulletSpeed = 2;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 10);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
    }
}
