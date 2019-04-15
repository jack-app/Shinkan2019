using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    static int killCount;

    // Start is called before the first frame update
    void Start()
    {
        killCount = 0;
    }

    public static void AddKill()
    {
        killCount++;
    }

    public static int GetKillCount()
    {
        return killCount;
    }
}
