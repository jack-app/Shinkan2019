using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardTekitama : MonoBehaviour {

    // Use this for initialization
    public GameObject Teki;
    public GameObject Jibun;
    public GameObject Tama;
    public float Kankaku;
    public float Sokudo;

    void Start () {
        if (Bullet_easy.bullet_number == 5)
        {
            Teki = GameObject.FindGameObjectWithTag("Enemy");
            Jibun = GameObject.FindGameObjectWithTag("Player");
            Tama.tag = "tama1";
            //Attackというスクリプトを弾に付加させています
            InvokeRepeating("Attack", 0.1f, Kankaku);
            InvokeRepeating("TD", 0.1f, 0.3f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void TD()
    {
        Instantiate(Tama, Teki.transform.position, Quaternion.identity);
        GameObject ob = GameObject.FindGameObjectWithTag("tama1");
        ob.AddComponent<chase>();
        ob.tag = "non";
    }
}
