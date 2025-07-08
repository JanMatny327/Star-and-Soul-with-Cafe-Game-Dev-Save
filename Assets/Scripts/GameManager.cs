using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class GameData
{
    [Header("튜토리얼을 하였는가?")]
    public bool isTutorial = false;

    [Header("인게임 데이터")]
    public string name;
    public int money;
}
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return instance;
        }
    }

    [Header("게임 데이터")]
    public GameData gameData;

    [ContextMenu("SaveData")]
    private void SaveData()
    {
        string data = JsonUtility.ToJson(gameData);
        string path = Path.Combine(Application.dataPath, data, "GameData.json");
        File.WriteAllText(path, data);
    }
}
