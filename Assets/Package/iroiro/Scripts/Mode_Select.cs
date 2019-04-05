using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class Mode_Select : MonoBehaviour
{ 

    public void Push()
    {
        SceneManager.LoadScene("ModeSelect_air");
    }

}

