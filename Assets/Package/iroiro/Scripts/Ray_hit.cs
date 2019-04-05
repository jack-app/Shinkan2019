using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ray_hit : MonoBehaviour {

    public RaycastHit hit;
    string hitjudge;
    public Text hittext;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousevec = Input.mousePosition;
            mousevec.z = 0;
            Ray ray = Camera.main.ScreenPointToRay(mousevec);
            if(Physics.Raycast(ray,out hit, 30))
            {
                hitjudge = "hit";
            }
            else { hitjudge = "failed"; }
        }
        hittext.text = hitjudge;
	}
}
