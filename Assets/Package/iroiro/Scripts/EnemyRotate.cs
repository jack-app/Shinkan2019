using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour {

    public GameObject player;
    float angp;
    float angn;
    public float speed;
    Vector3 right;
    Vector3 left;
    
	// Use this for initialization
	void Start () {
  right = new Vector3(0, -speed, 0);
        left = new Vector3(0,speed, 0);

    }

    // Update is called once per frame
    void Update () {
        angp = player.transform.rotation.eulerAngles.y;
        angn = gameObject.transform.rotation.eulerAngles.y;
        if (angp >= angn)
        {
            if (angp - angn > 180)
            {
                transform.Rotate(left, Space.World);
            }
            else
            {
                transform.Rotate(right, Space.World);
            }
        }
        else
        {
            if (angn - angp >= 180) {

                transform.Rotate(right, Space.World);
            }
            else
            {
                transform.Rotate(left, Space.World);
            }
        }
        
	}
}
