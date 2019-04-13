using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float timelimit;
    private bool a = true;
    public Text b;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(a == true)
        {
            a = false;
            StartCoroutine("time");
        }
        if(timelimit <= 0f)
        {
            Scorescript.tani = Scorescript.tani / 2;
            SceneManager.LoadScene("Clear");
        }

    }
    IEnumerator time()
    {

        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            timelimit -= 0.1f;
            b.text = "" + timelimit;


        }
    }
}

