using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utils
{
    public static void SceneMove(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static string SceneCheck(string sceneName)
    {
        sceneName = SceneManager.GetActiveScene().name;
        return sceneName;
    }
}
