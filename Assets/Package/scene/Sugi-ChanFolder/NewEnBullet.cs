using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnBullet : MonoBehaviour {

    public GameObject Teki;
    public GameObject Tama;
    public float Kankaku;
    // Use this for initialization
    void Start () {
        Teki = GameObject.FindGameObjectWithTag("Enemy");
        InvokeRepeating("Attack", 0.1f, Kankaku);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void Attack()
    {
        Instantiate(Tama, Teki.transform.position, Quaternion.identity);
    }
}
