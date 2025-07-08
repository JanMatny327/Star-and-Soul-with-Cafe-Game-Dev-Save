using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utils
{
    public static void SceneMove(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
