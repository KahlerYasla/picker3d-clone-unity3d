using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryAndNextButtons : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }

    public void Next()
    {
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
        SceneManager.LoadScene("Game");
    }
}
