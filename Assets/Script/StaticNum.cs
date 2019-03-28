using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class StaticNum : MonoBehaviour
{
    public static int num = 100;
    public static Stopwatch timer = new Stopwatch();
    public Image obj;
    private Color yielo = new Color(1.0f,1.0f,0f,0f);

    private void Start()
    {
        num = 100;
        yielo = new Color(1.0f, 1.0f, 0f, 0f);
        timer.Reset();
        timer.Start();
    }
    private void Update()
    {
        float temp = 0;
        temp = (num - 100) / 750f;
        yielo = new Color(1.0f, 1.0f, 0f, temp);
        obj.color = yielo;

    }

    void ActiveSceneChanged(Scene thisScene, Scene nextScene)
    {
        if(thisScene.name == "GameOver")
        {
            SceneManager.MoveGameObjectToScene(gameObject, nextScene);
            Destroy(gameObject);
        }
    }

    public void Timerstop()
    {
        timer.Stop();
    }
}
