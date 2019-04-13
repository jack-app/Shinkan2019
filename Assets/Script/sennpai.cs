using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sennpai : MonoBehaviour
{
    public GameObject w;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var v = Vector3.MoveTowards(GetComponent<Transform>().position, w.GetComponent<Transform>().position,Time.deltaTime);
        transform.position = v;
    }
}
