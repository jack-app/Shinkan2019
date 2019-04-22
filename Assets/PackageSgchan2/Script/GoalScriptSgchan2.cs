using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScriptSgchan2 : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameMasterSgchan2.Clear();
        }
    }
}
