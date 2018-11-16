using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float autoLoadLevelTime;

    public void Start()
    {
        if (autoLoadLevelTime > 0) { 
            Invoke("LoadNextLevel", autoLoadLevelTime);
        }
    }

    public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }

    public void QuitRequest()
    {
        print("Quit request received");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

}
