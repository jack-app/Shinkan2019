using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hushinsha : MonoBehaviour
{
    public float Speed;
    Rigidbody2D myRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myRigidbody2D.velocity.x < Speed)
        {
            myRigidbody2D.AddForce(Vector2.right * 30);
        }

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if(GetComponent<Renderer>().isVisible == false){
            Vector3 view_pos = new Vector3(0, 0.7f, 0);
            view_pos = Camera.main.ViewportToWorldPoint(view_pos);
            view_pos.z = 0;
            transform.position = view_pos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameMaster.GameOver();
        }
    }
}
