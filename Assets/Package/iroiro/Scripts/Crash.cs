using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCrash : MonoBehaviour {

    public GameObject a;
    public GameObject b;
    public GameObject enemy;
   // Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    //下のメソッドは衝突の際に実行する。ぶつかった相手はotherという名前になる
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Obstacle")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().hp-=1;
        }

    }
}
