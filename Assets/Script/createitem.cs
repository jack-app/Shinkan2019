using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createitem : MonoBehaviour
{
    public GameObject w;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fall", 2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }

    void Fall()
    {
        var v = player.gameObject.GetComponent<Transform>().position;
        int s = Random.Range(-20, 20);
        v += new Vector3(s, 10, 0);

        Instantiate(w, v, Quaternion.identity);
    }
}
