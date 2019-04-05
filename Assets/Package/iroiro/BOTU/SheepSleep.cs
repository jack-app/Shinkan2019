using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSleep : MonoBehaviour {

    public GameObject MKMK;
    public int a = 0;
    private void Start()
    {
        InvokeRepeating("MKMKi", 0.5f, 1.5f);
    }
    // Update is called once per frame
    void Update () {
			}
    void MKMKi()
    {
        a++;
        Instantiate(MKMK, new Vector3(0, 0, 160), Quaternion.identity);
    }
}
