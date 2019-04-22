using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySgchan1 : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            
                GameMasterSgchan1.GameOver();
            
        }

    }


}
