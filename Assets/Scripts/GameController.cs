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
        GameStart();
    }

    private void GameStart()
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
                Debug.Log("클릭이 감지됨.");
                Utils.SceneMove("InGame");
                return;
            }
        } 
    }
}
