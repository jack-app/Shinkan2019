using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySgchan2 : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //衝突の法線で上からの接触とそれ以外を分けています
            if (collision.contacts[0].normal == Vector2.down)
            {
                Destroy(gameObject);
            }
            else
            {
                GameMasterSgchan2.GameOver();
            }
        }

    }


}
