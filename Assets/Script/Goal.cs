using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Camera maincamera;

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
            GameMaster.clear = true;
            maincamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
            maincamera.GetComponent<CameraScript>().enabled = false;
            Invoke("Goaling", 4);
        }

    }

    void Goaling()
    {
        if (maincamera.orthographicSize < 7000)
        {

            maincamera.orthographicSize *= 1.01f;
            Invoke("Goaling", 0.03f);

        }
        else
        {
            Invoke("Last", 2);
           

        }
    }


    void Last()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Controller>().fallline = -4000;
        player.transform.position = new Vector3(0, 12000, -1);
        player.transform.localScale = Vector3.one * 1000;
        player.GetComponent<Rigidbody2D>().gravityScale *= 1000;
        Invoke("Win", 1.64f);
    }


    void Win()
    {
        GameMaster.clear = false;
        var wani=GameObject.Find("BigWani");
        GameMaster.Clear();
        Destroy(wani);
    }

}
