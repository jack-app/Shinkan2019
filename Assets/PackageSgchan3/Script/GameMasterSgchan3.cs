using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMasterSgchan3 : MonoBehaviour
{


    //このスクリプトでゲームオーバー, クリアのシーン遷移を制御します
    public static Vector3 restartpoint;
    public static bool clear;
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

        if (restartpoint == Vector3.zero) 
        {
            restartpoint = GameObject.FindGameObjectWithTag("Player").transform.position;
        }

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
            if (Input.GetKey(KeyCode.Return))
            {
                GameMasterSgchan3.Restart();

            }
            //クリアーまたはゲームオーバー時にエンターを押すと最初からになる


        }

    }

    public static void Clear()
    {
        if (!clear)
        {
            clear = true;
            GameObject.Find("ClearText1").GetComponent<Text>().text = "Clear";
            GameObject.Find("ClearText2").GetComponent<Text>().text = "Enter to Restart";
            restartpoint = Vector3.zero;
        }

    }

    public static void GameOver()
    {
        if (!clear)
        {

            gameover = true;
            SceneManager.LoadScene("GameOverSgchan3");

        }

    }

    public static void Restart()
    {
        SceneManager.LoadScene("MainSgchan3");

    }
}
