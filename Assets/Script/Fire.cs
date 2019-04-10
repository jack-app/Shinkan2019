using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject fire;
    private Vector3 firev;
    private float watosonv;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        firev = transform.position;
        if (Input.GetKey(KeyCode.C))
        {
            watosonv = transform.localScale.x;
            if (watosonv==1)
            {
                firev += new Vector3(1, 0, 0);
            }
            else
            {
                firev += new Vector3(-1, 0, 0);
            }
            Instantiate(fire, firev,Quaternion.identity);
        }
    }
}
