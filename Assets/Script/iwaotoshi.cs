using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iwaotoshi : MonoBehaviour
{
    public GameObject iwa;
    public Vector3 v;
    private bool x = true;
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (x ==true)
        {
            x = false;
            StartCoroutine("Iwa");
        }
    
    }
    IEnumerator Iwa()
    {
        yield return new WaitForSeconds(2f);

        GameObject iwa2 = Instantiate(iwa, v, Quaternion.identity);
        iwa2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1,-1,0)*power);
        x = true;
    }
}
