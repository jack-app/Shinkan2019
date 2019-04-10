using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public GameObject beam;
    Vector3 beamv;
    Vector3 vec;
    private float watosonv;
    bool x = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        beamv = transform.position;
        if (Input.GetKey(KeyCode.C))
        {
            if (x == true)
            {
                x = false;
                StartCoroutine("Tobasu");

            }


        }
    }
    IEnumerator Tobasu()
    {
        watosonv = transform.localScale.x;
        if (watosonv == 1)
        {
            beamv += new Vector3(1, 0, 0);
            vec = new Vector3(1, 0, 0);
        }
        else
        {
            beamv += new Vector3(-1, 0, 0);
            vec = new Vector3(-1, 0, 0);
        }
        GameObject beam2 = Instantiate(beam, beamv, Quaternion.identity);
        beam2.GetComponent<Rigidbody2D>().AddForce(vec * 1000);
        yield return new WaitForSeconds(3f);
        x = true;
    }
}
