using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardRandomSplash : MonoBehaviour {

    public GameObject bul;
    public GameObject mut;
    public GameObject ira;
    public GameObject mag;
    public GameObject niy;
    // Use this for initialization
    void Start()
    {
      
        if (Bullet_easy.bullet_number == 3)
        {
            InvokeRepeating("Bull", 0.1f, 2f);
        }
        if (Bullet_easy.bullet_number == 5)
        {
            InvokeRepeating("Bull", 0.03f, 0.042f);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
    void Bull()
    {
        Vector3 a = new Vector3(-1 + Random.value * 2, Random.value * 14, -1 + Random.value * 2);
        Instantiate(bul, a, Quaternion.identity);
        a = new Vector3(-1 + Random.value * 2, Random.value * 14, -1 + Random.value * 2);
        Instantiate(mut, a, Quaternion.identity);
        a = new Vector3(-1 + Random.value * 2, Random.value * 14, -1 + Random.value * 2);
        Instantiate(ira, a, Quaternion.identity);
        a = new Vector3(-1 + Random.value * 2, Random.value * 14, -1 + Random.value * 2);
        Instantiate(mag, a, Quaternion.identity);
        a = new Vector3(-1 + Random.value * 2, Random.value * 14, -1 + Random.value * 2);
        Instantiate(niy, a, Quaternion.identity);

    }
}
