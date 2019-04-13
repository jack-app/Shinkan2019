using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public int a;
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
        if (other.gameObject.tag == "Player")
        {
            //ここにアイテムの動きをかく
            Scorescript.tani += a;
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
