using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class Button_normal : MonoBehaviour
{


    public void Push()
    {
        Bullet_easy.bullet_number = 2;

         SceneManager.LoadScene("Start_air");
    }

}
