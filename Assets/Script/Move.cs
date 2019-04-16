using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //敵とか動く床とかに使ってください

    public Vector3[] destinationpositions;
    Vector3 position;
    int destinationnumber = 0;
    public float speed;
    // Use this for initialization
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.MoveTowardsは座標をだしてくれるらしい
        transform.position = Vector3.MoveTowards(transform.position, position+ destinationpositions[destinationnumber], speed * Time.deltaTime);
        if (transform.position ==position+ destinationpositions[destinationnumber])
        {
            //destinationnumberが最大になったら0に戻してそうでないときは++1
            destinationnumber = (destinationnumber + 1) % destinationpositions.Length;
        }


    }
}
