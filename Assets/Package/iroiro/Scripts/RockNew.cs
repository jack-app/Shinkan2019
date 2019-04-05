using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockNew : MonoBehaviour {
    GameObject sub;


    private void Start()
    {
       sub = GameObject.Find("Cube");
}

    // Update is called once per frame
    void Update () {
        //障害物はプレイヤーより10手前側に来ると消滅する
        if (transform.position.z < sub.transform.position.z - 10)
        {
            Destroy(gameObject);
        }
	}
   
}
