using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
//移動する成分の宣言
    Vector3 up = new Vector3(0, 0.4f, 0);
    Vector3 down = new Vector3(0, -0.4f, 0);
    Vector3 right = new Vector3(0.4f, 0, 0);
    Vector3 left = new Vector3(-0.4f, 0, 0);
//シーン上のパーツと結びつけるための器を宣言
    public GameObject Bullet;
    public GameObject WhiteCube;
    public GameObject HevBullet;
  

    // Update is called once per frame
    public void Update()
    {//一定の速度でプレイヤーを前に進める
        transform.Translate(0, 0, 0.7f * Time.deltaTime * 60);

        //ボタンを押したときに処理を実行する
        if (Input.GetKey(KeyCode.UpArrow)&&transform.position.y<=20)
        {
            transform.Translate(up,Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow)&& transform.position.y >= -20)
        {
            transform.Translate(down, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 19.8f)
        {
            transform.Translate(right, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -19.8f)
        {
            transform.Translate(left, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Variables.bulletnumber> 0)
            {
                //ボタンを押してる間ずっと処理を実行させ続ける
                InvokeRepeating("Burst", 0, 0.05f);
                
            }         
        }
        //Fキーを離したら処理の繰り返しをやめる
        if (Input.GetKeyUp(KeyCode.F))
        {
            
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            //下の方にに書いてある"Heaavyburst"という名前のメソッド（処理）を実行する
            Heavyburst();

            
        }
 
        
    }
    void Burst()
    {
        if (Variables.bulletnumber > 0)
        {/*物体を画面上に出現させる
            [instantiate(出現させる物体{これはスクリプトの最初で宣言が必要｝, 出現させたい座標, 回転の向き｛これはよくわかんないけど"Quaternion.identity"て書けばOK｝）
            transform.position.xはこのスクリプトが入っている物体のx座標を出力する*/
            Instantiate(Bullet,new Vector3(transform.position.x,transform.position.y,transform.position.z+2), Quaternion.identity);
            Variables.bulletnumber -= 1;
        }
       
    }
    void Heavyburst()
    {
        if (Variables.heavybulletcountor > 0)
        {
            Instantiate(HevBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z +4), Quaternion.identity);
            Variables.heavybulletcountor -= 1;
        }
    }
}