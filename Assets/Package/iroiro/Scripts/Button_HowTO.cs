using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Button_HowTO : MonoBehaviour {

	public void push()
    {
        SceneManager.LoadScene("Start_air");
    }
}
