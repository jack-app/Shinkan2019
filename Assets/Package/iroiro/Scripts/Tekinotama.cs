using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tekinotama : MonoBehaviour {
    //staticと書かれたものは後で出てくるAttackというスクリプトに渡すための情報です
    public GameObject Teki;
    public GameObject Jibun;
    public GameObject Tama;
    public float Kankaku;
    public float Sokudo;


	// Use this for initialization
	void Start () {
        Teki = GameObject.FindGameObjectWithTag("Enemy");
        Jibun = GameObject.FindGameObjectWithTag("Player");
        Tama.tag = "tama";
        //Attackというスクリプトを弾に付加させています
        InvokeRepeating("Attack", 0.1f, Kankaku);



	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Attack()
    {
        Instantiate(Tama, Teki.transform.position, Quaternion.identity);
        GameObject ob=GameObject.FindGameObjectWithTag("tama");
        ob.AddComponent<chase>();
        ob.tag = "non";
    }
}
