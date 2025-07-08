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
                Debug.Log("Ŭ���� �����Ǿ���. Ʃ�丮���� �������� ����.");
                return;
            }
            else
            {
                Debug.Log("Ŭ���� ������.");
                Utils.SceneMove("InGame");
                return;
            }
        } 
    }
}
