using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointSgchan3 : MonoBehaviour
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
        if (collision.tag == "Player")
        {
            GameMasterSgchan3.restartpoint = transform.position + 10*Vector3.up;
        }
    }
}
