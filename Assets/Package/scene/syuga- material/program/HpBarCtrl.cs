using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる
using UnityEngine.SceneManagement;

public class HpBarCtrl : MonoBehaviour
{
    public float _hp = 499;
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {

        // HPゲージに値を設定
        _slider.value = _hp;
        // 
        if (_hp == 0)
        {
            // 最大を超えたら0に戻す
            _hp = 500;
        }
        if (_hp == 1)
        {
            // 最大を超えたら0に戻す
            SceneManager.LoadScene("Result_air");
        }
    }
}