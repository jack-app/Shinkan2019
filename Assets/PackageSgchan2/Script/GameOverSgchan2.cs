using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverSgchan2 : MonoBehaviour
{
    public Sprite aa;
    public Sprite b;
        public Sprite c;
        public Sprite d;
        public Sprite e;
        public Sprite f;
    public Sprite g;
    public Image image;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "集めたパーツは" + GameMasterSgchan2.partsnumber + "コです";

        var a = GameMasterSgchan2.partsnumber;
        if (a==40)
        {
            image.sprite = aa;
        }
        if (a>=30&&a<=39)
        {
            image.sprite = b;
        }
        if (a>=25&&a<=29)
        {
            image.sprite = c;
        }
        if (a<=24&&a>=20)
        {
            image.sprite = d;
        }
        if (a>=15&&a<=19)
        {
            image.sprite = e;
        }
        if (a<=14&&a>=10)
        {
            image.sprite = f;
        }
        if (a<=9)
        {
            image.sprite = g;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            GameMasterSgchan2.Restart();

        }
    }
}
