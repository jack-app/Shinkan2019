using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiSgchan2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GameMasterSgchan2.partsnumber += 1;
            Destroy(gameObject);
        }
    }
}
