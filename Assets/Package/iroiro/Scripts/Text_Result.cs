using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class Text_Result : MonoBehaviour
{

    public static int Result_point;

    private void Start()
    {
        string point;
        point = Result_point.ToString();
        this.GetComponent<Text>().text = point;
    }


}