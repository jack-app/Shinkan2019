using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSgchan3 : MonoBehaviour
{

    //敵とか動く床とかに使ってください

    public Vector3[] destinationpositions;
    Vector3 position;
    int destinationnumber = 0;
    public float speed;
    Vector3 moveposition;
    // Use this for initialization
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveposition = Vector3.MoveTowards(transform.position, position + destinationpositions[destinationnumber], speed * Time.deltaTime);
        //Vector3.MoveTowardsは座標をだしてくれるらしい
        Direction();
        transform.position = moveposition;
        if (transform.position == position + destinationpositions[destinationnumber])
        {
            //destinationnumberが最大になったら0に戻してそうでないときは++1
            destinationnumber = (destinationnumber + 1) % destinationpositions.Length;
        }


    }

    void Direction()
    {
        var direction = moveposition - transform.position;
        transform.localScale = new Vector3(direction.x == 0 ? 1 : -System.Math.Sign(direction.x), 1, 1);
    }
}
