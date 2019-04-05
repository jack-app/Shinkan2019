using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Button_HowTo : MonoBehaviour {

	public void Push()
    {
        SceneManager.LoadScene("HOWTO_air");
    }
}
