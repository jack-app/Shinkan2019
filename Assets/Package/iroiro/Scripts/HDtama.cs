using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDtama : MonoBehaviour {

    public GameObject Teki;
    public GameObject Jibun;
    public GameObject Tama;
    public float Kankaku;
    public float Sokudo;


    // Use this for initialization
    void Start()
    {
        if (Bullet_easy.bullet_number == 5)
        {

        Teki = GameObject.FindGameObjectWithTag("Enemy");
        Jibun = GameObject.FindGameObjectWithTag("Player");
        Tama.tag = "tama1";
        //Attackというスクリプトを弾に付加させています
        InvokeRepeating("Attack", 0.1f, Kankaku);
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
    void Attack()
    {
        Vector3 aa = transform.position;
        aa.y += 4;
        Instantiate(Tama, Teki.transform.position, Quaternion.identity);
        GameObject ob = GameObject.FindGameObjectWithTag("tama1");
        ob.AddComponent<chase>();
        ob.tag = "non";
    }
}
