using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iwamove : MonoBehaviour
{
    private int x;
    private int y;
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
 
        if (other.gameObject.tag == "Ground")
        {
            x = Random.Range(-5, 5);
            y = Random.Range(0, 10);
            Vector2 vec = new Vector2(x, y);
            GetComponent<Rigidbody2D>().AddForce(vec*500);
        }
        if (other.gameObject.tag == "Player")
        {
            GameMaster.GameOver();
        }
    }
}
