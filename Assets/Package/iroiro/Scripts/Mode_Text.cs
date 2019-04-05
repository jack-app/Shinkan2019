using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Mode_Text : MonoBehaviour
{
    public int bullets;
    string Mode;

    private void Start()
    {
        bullets = Bullet_easy.bullet_number;

        if (bullets == 5)
        {
            Mode = "Hell";
        }else if (bullets == 2)
        {
            Mode = "Normal";
        }else if (bullets == 3)
        {
            Mode = "Hard";
        }else
        {
            Mode = "Easy";
            Bullet_easy.bullet_number = 1;
        }

        this.GetComponent<Text>().text = Mode;

    }
}