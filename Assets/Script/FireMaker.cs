using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMaker : MonoBehaviour
{
    GameObject fire;

    float times;
    private void Start()
    {
        fire = Resources.Load("Prefabs/火") as GameObject;
        times = 0f;
    }


    // Update is called once per frame
    void Update()
    {

        times += Time.deltaTime;

        if(times >= 0.5f)
        {
            times = 0f;

            Instantiate(fire, transform.position + new Vector3(2f, 0f, 0f), Quaternion.identity);
        }
    }
}
