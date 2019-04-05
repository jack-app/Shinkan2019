using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class Bullet_easy : MonoBehaviour{

    public static int bullet_number;

    public void Push()
    {
        Bullet_easy.bullet_number = 1;

        SceneManager.LoadScene("Start_air");
    }

}