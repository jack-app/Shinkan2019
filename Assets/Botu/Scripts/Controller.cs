using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {


    public Vector3 velocity;
    public float speed;
    public float jump;
    public Vector3 startposition;
    public bool onground;
    public float height;
	// Use this for initialization
	void Start () {
        startposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

            if (Onground())
            {
            if (Input.GetKey(KeyCode.Space))
            {

                velocity.y += jump;
            
            }

            
            }
        
        else
        {
        velocity.y -= 9.8f * Time.deltaTime;

        }
        velocity.x = Input.GetAxis("Horizontal");
        Move();

        Fall();

	}

    bool Onground()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit, height*1.1f))
        {
            transform.position = hit.point + height * Vector3.up;
            velocity.y = 0;
            onground = true;
            return true;
        }
        else
        {
            onground = false;
            return false;
        }
    }


    private void Move()
    {

        var holizon = new Vector3(speed*Time.deltaTime*velocity.x, 0, 0);
        var vertical = new Vector3(0,speed*Time.deltaTime*velocity.y, 0);
        Ray rayholizon = new Ray(transform.position, holizon);
        Ray rayvertical = new Ray(transform.position, vertical);
        RaycastHit hit;
        if (Physics.Raycast(rayholizon,out hit, Vector3.Magnitude(holizon)))
        {
            if (hit.point.x <= transform.position.x)
            {
                transform.position = hit.point+0.01f*Vector3.right;
                velocity.x = 0;

            }
            else
            {
                transform.position = hit.point+0.01f*Vector3.left;
                velocity.x = 0;
            }
           
        }
        else
        {
            transform.Translate(holizon);
        }

        if(Physics.Raycast(rayvertical,out hit, Vector3.Magnitude(vertical)+height))
        {
            if (hit.point.y <= transform.position.y)
            {
            transform.position = hit.point+height*Vector3.up;
            velocity.y=0;
                onground = true;
            }
            else
            {
                transform.position = hit.point;
                velocity.y = 0;
            }

        }
        else
        {
            transform.Translate(vertical);
        }

    }

    void Fall()
    {
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
