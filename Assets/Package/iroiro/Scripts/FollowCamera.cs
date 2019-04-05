using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public GameObject parent;
    GameObject cmr;
    public GameObject spon;

    private void Start()
    {
        //Findはゲームで起動している物体のうち指定された名前のものを探してくれる
    cmr = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update () {
        //スクリプトを入れた物体でないものの位置情報が欲しいときは　"スクリプトの最初で宣言した名前”+".transform.position"
        Vector3 vec = parent.transform.position;
        vec.z -= 15;
        cmr.transform.position=vec;
        spon.transform.position = new Vector3(0,0,parent.transform.position.z+90);
    }
}
