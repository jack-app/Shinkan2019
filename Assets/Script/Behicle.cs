using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behicle : MonoBehaviour
{
    public float Speed;
    public float ReturnTime = 1;

    public float StartPosition;

    public bool canMove = false;

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * Speed;
        }

        if(transform.position.x - Player.transform.position.x < StartPosition && canMove == false){
            canMove = true;
            StartCoroutine(ReturnCoroutin());
        }
    }

    public void Back(){
        Speed = -Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameMaster.GameOver();
        }
    }

    IEnumerator ReturnCoroutin(){
        yield return new WaitForSeconds(ReturnTime);
        Back();
    }
}
