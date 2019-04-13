using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{


    //このスクリプトでゲームオーバー, クリアのシーン遷移を制御します

    static bool clear;
    static bool gameover;
    static GameObject firstinstance;
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //このオブジェクトがシーン遷移で消えないように                  

    }

    private void Awake()
    {
        clear = gameover = false;

        //2回目のシーン読み込み以降はGameMasterが生成されないように
        if (firstinstance == null)
        {
            firstinstance = this.gameObject;
        }
        else
        {
            if (firstinstance != this.gameObject)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (clear || gameover)
        {
            //クリアーまたはゲームオーバー時にエンターを押すと最初からになる
            if (Input.GetKey(KeyCode.Return))
            {
                GameMaster.Restart();

            }

        }

    }

    public static void Clear()
    {
        if (!clear)
        {
            clear = true;
            GameObject.Find("ClearText1").GetComponent<Text>().text = "Clear";
            GameObject.Find("ClearText2").GetComponent<Text>().text = "Enter to Restart";
        }

    }

    public static void GameOver()
    {
        if (!clear)
        {
            Scorescript.tani = Scorescript.tani / 2;
            gameover = true;
            SceneManager.LoadScene("Clear");

        }

    }

    public static void Restart()
    {
        SceneManager.LoadScene("Main");

    }
}
