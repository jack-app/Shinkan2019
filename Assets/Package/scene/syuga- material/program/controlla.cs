using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlla : MonoBehaviour
{
    public float sokudo;
    public GameObject Prefab;
    float intervalTime;


    // Use this for initialization
    void Start()
    {
    intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, sokudo, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -sokudo, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(sokudo, 0, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-sokudo, 0, 0), Space.World);
        }
        intervalTime += Time.deltaTime;
       
            if (intervalTime >= 0.1f)
            {
                intervalTime = 0.0f;
                Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z+5), Quaternion.identity);
            }
        
    }
}