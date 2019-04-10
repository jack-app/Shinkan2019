using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hatenablock : MonoBehaviour
{
    public GameObject Block;//ハテナブロック
    public GameObject Hatena;//UIの"？"の部分
    private bool controller = true;//イベント制御用
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 下からたたいたら色が変わる
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (controller == true)
            {
                controller = false;
                StartCoroutine("Hatenanonakami");
            }
            Block.GetComponent<Renderer>().material.color = new Color(0f / 255f, 0f / 255f, 0);
            Hatena.SetActive(false);
        }

    }
    /// <summary>
    ///ハテナブロックの中身をここに書きます。 
    /// </summary>
    /// <returns></returns>
    IEnumerator Hatenanonakami()
    {
        yield return new WaitForSeconds(1f);
        controller = true;
    }
}
