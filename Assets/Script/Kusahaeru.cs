using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusahaeru : MonoBehaviour
{
    public GameObject Hana;
    public float xx = 0;//生成するx座標
    public float yy = 0;//生成するy座標
    public int speed;//上昇(下降)速度
    int destinationnumber = 0;//移動位置番号
    public Vector3[] destinationpositions;//移動位置
    private bool f = true;//花召喚フラグ
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (f ==true)
        {
            f = false;
            StartCoroutine("Pakkunn");
        }

    }
    private IEnumerator Pakkunn()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(Hana,new Vector3(xx,yy,0),Quaternion.identity);
        Hana.transform.position = Vector3.MoveTowards(Hana.transform.position, destinationpositions[destinationnumber], speed * Time.deltaTime);
        if (transform.position == destinationpositions[destinationnumber])
        {
            //destinationnumberが最大になったら0に戻してそうでないときは++1
            destinationnumber = (destinationnumber + 1) % destinationpositions.Length;
            //destinationnumberが0になったら(元の位置に戻ったら)そのオブジェクトを消滅
            if (destinationnumber == 0)
            {
                Destroy(Hana);
            }
        }
        f = true;
    }
}
