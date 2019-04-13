using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teki : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            //ここに敵の動きをかく
            Scorescript.tani -= 1000;
            transform.position= new Vector3(0,0,0);
        }
    }
}
