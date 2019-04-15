using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "W君")
        {
            collision.gameObject.AddComponent(typeof(FireMaker));

            Destroy(gameObject);
        }
    }
}
