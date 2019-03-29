using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {


            //このスクリプトでゲームオーバー, クリアのシーン遷移を制御します

    static bool clear;
    static bool gameover;
    static GameObject c;
    public GameObject cleartext;
    static GameObject firstinstance;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject); //このオブジェクトがシーン遷移で消えないように
        c = cleartext;                      

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
    void Update () {
        if (clear||gameover)
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
            c.SetActive(true); //クリアー時にテキストを表示
        }
       
    }

    public static void GameOver()
    {
        if (!clear)
        {
            
            gameover = true;
            SceneManager.LoadScene("GameOver");
            
        }

    }

    public static void Restart()
    {
        SceneManager.LoadScene("Main"); 
       
    }
}
