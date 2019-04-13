using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBull : MonoBehaviour
{

    public GameObject bull;
    public Vector3 v;
    private bool x = true;
    public int power;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (x == true)
        {
            x = false;
            StartCoroutine("red");
        }

    }
    IEnumerator red()
    {
        yield return new WaitForSeconds(1f);

        GameObject iwa2 = Instantiate(bull, v, Quaternion.identity);
        x = true;
    }
}
