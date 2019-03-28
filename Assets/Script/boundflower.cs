using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class boundflower : MonoBehaviour
{
    public int power;
    private Rigidbody2D addp;
    public GameObject panel;
    private void Start()
    {
        panel.GetComponent<Image>().color = new Color(1, 1, 0, 0);
    }
    //花との衝突時吹っ飛ぶ
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Player"))
        {
        
            GameObject player = GameObject.FindGameObjectsWithTag("Player").First();
            GameObject flower = GameObject.FindGameObjectsWithTag("Flower").First();
            //跳ね返す方向のベクトル生成
            //var addv = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z) - new Vector3(flower.transform.position.x, transform.position.y, transform.position.z);
            var addv = collision2D.GetContact(0).normal * -1;

            addp = player.GetComponent<Rigidbody2D>();
            addp.velocity = Vector2.zero;
            addp.AddForce(addv*power);
            power += 400;

            panel.GetComponent<Image>().color +=new Color(0, 0, 0, 15f/255f);
            if (panel.GetComponent<Image>().color == new Color(1, 1, 0, 1))
            {
                GameMaster.GameOver();
            }

        }
    }
}
