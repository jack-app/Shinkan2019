using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {


   bool a=false;
    public float test1;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Judge", 0.1f, 2);
       
        if (Bullet_easy.bullet_number == 5)
        {
            a = true;

 
        }
    }
	
	// Update is called once per frame
	void Judge() {
        float add = Mathf.Sqrt(transform.position.x*transform.position.x + transform.position.y*transform.position.y + transform.position.z*transform.position.z);
        if (add > 62)
        {
            Destroy(gameObject);
        }
        if (a)
        {
            Vector3 pos = transform.position;
            Vector3 pr = PlayerLocation.pr;
            float a = pos.x * pr.x + pos.z * pr.z;
            float poss = pos.x * pos.x + pos.z * pos.z;
            float cos = a / (Mathf.Sqrt(poss * PlayerLocation.prr));
            if (cos <= 0.1)
            {
                Destroy(gameObject);
            }
      
        }
    }
}
