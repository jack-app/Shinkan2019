using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class Bullet_survivor : MonoBehaviour
{

    public void Push()
    {
        Bullet_easy.bullet_number = 5;
        SceneManager.LoadScene("Start_air");
    }
}