using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerSgchan3 : MonoBehaviour
{

    private new Rigidbody2D rigidbody;
    private bool onground;
    private Animator anim;
    private ControllerSgchan3 controllerreference;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        controllerreference = GetComponent<ControllerSgchan3>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("OnGround", controllerreference.onground);

        //移動にAddForceを使っているため完全に止まるまで時間がかかるので速度の大きさ0.2f以下は静止していることにする
        if (Mathf.Abs(rigidbody.velocity.x) < 0.2f)
        {
            anim.SetBool("Run", false);
        }
        else
        {
            anim.SetBool("Run", true);

            //速度の正負によって向きを変える
            if (rigidbody.velocity.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1)*transform.localScale.y;
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1)*transform.localScale.y;
            }

        }
    }
}
