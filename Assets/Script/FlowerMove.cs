using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using System.Collections;

public class FlowerMove : MonoBehaviour
{
    private RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    private Vector2 vec = Vector2.zero;
    private float pos = -5;
    private byte[] temp = new byte[1];

    private void Start()
    {
        vec.x = transform.position.x;
        vec.y = -5f;
        StartCoroutine(Move());
    }

    // Update is called once per frame
    private IEnumerator Move()
    {
        while(true){
            rng.GetBytes(temp);
            if (temp[0] % 2 == 0)
            {
                if (pos == -5)
                {
                    StartCoroutine(Moving(-5, 8));
                }
            }
            else
            {
                if (pos == 8)
                {
                    StartCoroutine(Moving(8,-5));
                }
            }

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator Moving(float start, float end)
    {
        float Parameter = 0;
        while (Parameter <= 1)
        {
            pos = Mathf.Lerp(start, end, Parameter / 0.9f);
            vec.y = pos;

            transform.position = vec;
            yield return null;

            Parameter += Time.deltaTime;
        }
    }
}
