using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addforce : MonoBehaviour
{
    public Rigidbody2D obj;
    [SerializeField]
    [Range(0,0.1f)]
    private float power = 0.01f;

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Vector2 normal = Vector2.zero;

        //法線ベクトルを取得
        foreach (ContactPoint2D contact in collision.contacts)
        {

            if (contact.collider.name == "W君")
            {
                normal = contact.normal;

                obj.AddForce(-normal * StaticNum.num * power,ForceMode2D.Impulse);
                StaticNum.num++;
            }
        }
    }
}
