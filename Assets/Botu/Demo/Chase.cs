using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chase : MonoBehaviour {

    public Vector3 futtobi;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed*Time.deltaTime, 0, 0);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("Futtobi", other.gameObject);
        }
    }

    IEnumerator Futtobi(GameObject player)
    {

        player.GetComponent<Controller>().onground = false;
            for (int i=0; i < 100; i++)
        {
        if (player.GetComponent<Controller>().onground==true)
        {
           break; 
        }
        
        
            player.transform.position = player.transform.position + futtobi;
            yield return null;


        }

        
         }
 }
    

