using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalSpon : MonoBehaviour {

    public GameObject dasumono;
    public float kankaku;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spon", 0.1f, kankaku);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spon()
    {
        Vector3 pos = transform.position;
        pos.y += 4;
        Instantiate(dasumono, pos, Quaternion.identity);
    }
}
