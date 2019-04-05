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

    public GameObject Zokin;
    public GameObject Sojiki;
    public GameObject Runba;

    public Text TimeText;

    private float time;
    private IEnumerator timeCoroutine;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //このオブジェクトがシーン遷移で消えないように                  
        StartCoroutine(MakeEnemiesCoroutine());
        timeCoroutine = TimerCoroutine();
        StartCoroutine(timeCoroutine);
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
            StopCoroutine(timeCoroutine);
            //TimeText.transform.position = new Vector3(15, 7, 0);
            TimeText.fontSize = 100;
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

            gameover = true;
            //SceneManager.LoadScene("GameOver");

        }

    }

    public static void Restart()
    {
        SceneManager.LoadScene("Main");

    }

    IEnumerator MakeZokinCoroutine(){
        while (true)
        {
            yield return new WaitForSeconds(3);
            MakeZokin();
        }
    }

    IEnumerator MakeSojikiCoroutine(){
        while (true)
        {
            yield return new WaitForSeconds(3);
            MakeSojiki();
        }
    }

    IEnumerator MakeRunbaCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            MakeRunba();
        }
    }

    IEnumerator MakeEnemiesCoroutine(){
        StartCoroutine(MakeZokinCoroutine());
        yield return new WaitForSeconds(10);
        StartCoroutine(MakeSojikiCoroutine());
        yield return new WaitForSeconds(10);
        StartCoroutine(MakeRunbaCoroutine());
    }

    void MakeZokin(){
        int r = Random.Range(-15, 15);
        Instantiate(Zokin, new Vector3(r, 12, 0), Quaternion.identity);
    }

    void MakeSojiki(){
        int r = Random.Range(-15, 15);
        Instantiate(Sojiki, new Vector3(r, 6, 0), Quaternion.identity);
    }

    void MakeRunba(){
        int r = Random.Range(-15, 15);
        Instantiate(Runba, new Vector3(r, 2, 0), Quaternion.identity);
    }

    IEnumerator TimerCoroutine(){
        while(true){
            yield return new WaitForSeconds(0.1f);
            time += 0.1f; 
            TimeText.text = time.ToString();
        }
    }
}
