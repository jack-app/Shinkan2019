using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardMode : MonoBehaviour
{

    public GameObject td;
    public GameObject en;
    public GameObject pl;
    public GameObject jk;
    public GameObject fd;
    public Camera cmr;
    // Use this for initialization
    void Start()
    {

        td = GameObject.FindGameObjectWithTag("tamadashi");
        en = GameObject.FindGameObjectWithTag("Enemy");
        pl = GameObject.FindGameObjectWithTag("Player");
        jk = GameObject.FindGameObjectWithTag("JACKUN");
        cmr = GameObject.Find("JKCamera").GetComponent< Camera >();

        if (Bullet_easy.bullet_number == 1)
        {
            en.GetComponent<IntervalSpon>().kankaku = 0;
            Invoke("Fradra3", 20);
            td.GetComponent<Tekinotama>().Kankaku = 8;
            en.transform.localScale = new Vector3(1, 1, 1);
            pl.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            jk.transform.localScale = new Vector3(70, 70, 70);
            pl.GetComponent<Obitcontroller>().speed = 0.8f;
            en.GetComponent<RandomSplash>().interval = 9f;
            cmr.farClipPlane = 200;

        }
        if (Bullet_easy.bullet_number == 2)
        {
            en.transform.localScale = new Vector3(1, 1, 1);
            en.GetComponent<RandomSplash>().interval = 2f;
            td.GetComponent<Tekinotama>().Kankaku = 1;
            en.GetComponent<IntervalSpon>().kankaku = 2;
            pl.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            jk.transform.localScale = new Vector3(100, 100, 100);
            pl.GetComponent<Obitcontroller>().speed = 1f;
            Invoke("Fradra1", 20);
            cmr.farClipPlane = 200;

        }
        if (Bullet_easy.bullet_number == 3)
        {
            en.GetComponent<RandomSplash>().interval = 10f;
            en.transform.localScale = new Vector3(2, 2, 2);
            td.GetComponent<Tekinotama>().Kankaku = 0.1f;
            pl.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            jk.transform.localScale = new Vector3(100, 100, 100);
            pl.GetComponent<Obitcontroller>().speed = 1f;
            Invoke("Fradra2", 20);
            en.GetComponent<IntervalSpon>().kankaku = 10;
            cmr.farClipPlane = 200;
        }
        if (Bullet_easy.bullet_number == 5)
        {
            en.transform.localScale = new Vector3(2f, 2f, 2f);
            en.GetComponent<RandomSplash>().interval = 20f;
            td.GetComponent<Tekinotama>().Kankaku = 61;
            en.GetComponent<IntervalSpon>().kankaku = 15;
            pl.GetComponent<BoxCollider>().size = new Vector3(0.5f, 0.5f, 0.5f);
            jk.transform.localScale = new Vector3(50, 50, 50);
            pl.GetComponent<Obitcontroller>().speed = 0.5f;
            cmr.farClipPlane = 200;


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Fradra()
    {
       

    }
    void Fradra1()
    {
        
    }
    void Fradra2()
    {
       
    }
    void Fradra3()
    {
      
    }
}
