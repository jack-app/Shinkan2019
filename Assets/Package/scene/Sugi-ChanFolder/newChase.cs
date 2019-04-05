using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newChase : MonoBehaviour {
    Vector3 go;
    public GameObject me;
    public float time;
    public float a;
    GameObject ws;

    // Use this for initialization
    void Start()
    {

        ws = GameObject.FindGameObjectWithTag("WS");
        me = ws.GetComponent<HardMode>().pl;
        go = new Vector3((me.transform.position.x - transform.position.x) * time / 100, (me.transform.position.y - transform.position.y) * time / 100, (me.transform.position.z - transform.position.z) * time / 100);
        a = go.z;
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(go, Space.World);
    }
}
