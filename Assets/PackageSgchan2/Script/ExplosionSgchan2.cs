using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSgchan2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
