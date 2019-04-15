using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Time = 0;
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TimerCoroutine(){
        while(true){
            yield return new WaitForSeconds(0.1f);
            Time += 0.1f;
            TimerText.text = Time.ToString();
            if(GameMaster.IsClear){
                break;
            }
        }
    }
}
