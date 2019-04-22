using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScriptSgchan1 : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameMasterSgchan1.Clear();
        }
    }
}
