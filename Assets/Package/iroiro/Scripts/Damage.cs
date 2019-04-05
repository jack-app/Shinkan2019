using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Untagged")
        {

        }
        else
        {
            
            SceneManager.LoadScene("GameOver222");
        }
      
           
        
    }
}
