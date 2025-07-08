using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameController _instance = new GameController();
    public static GameController instance => _instance;

    private void Update()
    {
        if (Utils.SceneCheck(null) == "Lobby")
        {
            GameStart();
        }
    }

    public void GameStart()
    {
        if (Input.anyKey)
        {
            if (!GameManager.instance.gameData.isTutorial)
            {
                Debug.Log("클릭이 감지되었고. 튜토리얼을 진행하지 않음.");
                return;
            }
            else
            {
                Utils.SceneMove("InGame");
                return;
            }
        } 
    }
}
