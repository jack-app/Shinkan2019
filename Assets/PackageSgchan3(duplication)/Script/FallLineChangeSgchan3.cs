using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallLineChangeSgchan3 : MonoBehaviour
{
    public int newfallline;
    Camera maincamera;

     public enum CaveInorOut
    {
        In,
        Out,
    }

    public CaveInorOut caveInorOut;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<ControllerSgchan3>().fallline = newfallline;
        }

        maincamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); 
        switch (caveInorOut)
        {
            case CaveInorOut.In:
                InCave();
                break;

            case CaveInorOut.Out:
                OutCave();
                break;

        }
    }

    void InCave()
    {
        if (maincamera.orthographicSize<20)
        {
            maincamera.orthographicSize += 0.1f;
            Invoke("InCave", 0.05f);
        }
    }

    void OutCave()
    {
        if (maincamera.orthographicSize > 15)
        {
            maincamera.orthographicSize -= 0.1f;
            Invoke("OutCave", 0.05f);
        }
    }
}
