using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public void Start()
    {
        // load the next level
        int currentLevel = PlayerPrefs.GetInt("Level");

        currentLevel++;
        Debug.Log("currentLevel: " + currentLevel);

        // load the level from Resources
        GameObject level = Instantiate(Resources.Load("Level" + currentLevel)) as GameObject;
    }

}
