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
                Debug.Log("Ŭ���� �����Ǿ���. Ʃ�丮���� �������� ����.");
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
