using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koumeinowana : MonoBehaviour
{
    public GameObject Block;
    /// <summary>
    /// 下からたたいたら色が変わる
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Block.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255f/255f);
        }

    }
}
