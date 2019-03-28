using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    Vector3 scaleVec = new Vector3(0, 0.05f,0);
    float waitTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = Random.Range(2f,10f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        waitTime -= Time.deltaTime;

        if (waitTime < 0)
        {
            transform.localScale += scaleVec;

            if (transform.localScale.y >= 1f)
            {
                waitTime = RandomTime();
                scaleVec = Down();
            }
            else if (transform.localScale.y <= 0f)
            {
                waitTime = RandomTime();
                scaleVec = Up();
            }
        }

        /*if (transform.localScale.y >= 1f)
        {
            waitTime = RandomTime();
            Debug.Log(waitTime);
            scaleVec = Down();
        }
        else if(transform.localScale.y <= 0f)
        {
            waitTime = RandomTime();
            scaleVec = Up();
        }*/

    }

    float RandomTime()
    {
        return Random.Range(1f, 3f);
    }

    Vector3 Up()
    {
        return new Vector3(0, 0.05f, 0);
    }

    Vector3 Down()
    {
        return new Vector3(0,-0.05f, 0);
    }

    
}
