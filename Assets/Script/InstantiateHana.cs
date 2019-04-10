using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateHana : MonoBehaviour
{
    //この下はてなの中身(テスト)
    public GameObject Hatenablock;
    public GameObject Hana;
    private static GameObject hana;
    private static Vector2 InstatiateHanav;
    private void Start()
    {
        InstatiateHanav = Hatenablock.GetComponent<Transform>().position + new Vector3(0,5,0);
        hana = Hana;
    }
    public static void Hanaderu()
    {
        Instantiate(hana, InstatiateHanav, Quaternion.identity);
    }
}
