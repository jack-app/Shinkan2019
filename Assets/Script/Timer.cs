using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text textComp;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("TimeText") != null)
        {
            GetComponent<Text>().text = GameMaster.time.ToString("F2") + "s";
        }
        else
        {
            textComp = GetComponent<Text>();
            GameMaster.time = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (textComp != null)
        {
            GameMaster.time += Time.deltaTime;
            textComp.text = GameMaster.time.ToString("F2") + "s";
        }
    }
}
