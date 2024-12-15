using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static DataController _instance;
    public static DataController instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent<DataController>();
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public string GameDataFileName = "Data.json";
    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            if (_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string[] targetScenes = { "GameScene_1", "GameScene_2", "GameScene_3" };
        if (Array.Exists(targetScenes, sceneName => sceneName == scene.name))
        {
            SaveSceneName(scene.name);
            Debug.Log("씬 이름이 저장되었음: " + scene.name);
        }
    }

    public void LoadGameData()
    {
        string filepath = Application.persistentDataPath + "/" + GameDataFileName;
        if (File.Exists(filepath))
        {
            Debug.Log("불러오기에 성공했다....");
            string FromJsonData = File.ReadAllText(filepath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);

            GameManager.instance.previousScene = _gameData.previousScene;
            GameManager.instance.isLockedChecked = _gameData.isLockedChecked;
            GameManager.instance.isTalkedWithDarae = _gameData.isTalkedWithDarae;
            GameManager.instance.isLighter = _gameData.isLighter;
            GameManager.instance.isMaka = _gameData.isMaka;
            GameManager.instance.isAlbum = _gameData.isAlbum;
            GameManager.instance.num = _gameData.num;
        }
        else
        {
            Debug.Log("새로운 파일 생성");
            _gameData = new GameData();
        }
    }

    public void SaveGameData()
    {
        
        _gameData.previousScene = GameManager.instance.previousScene;
        _gameData.isLockedChecked = GameManager.instance.isLockedChecked;
        _gameData.isTalkedWithDarae = GameManager.instance.isTalkedWithDarae;
        _gameData.isLighter = GameManager.instance.isLighter;
        _gameData.isMaka = GameManager.instance.isMaka;
        _gameData.isAlbum = GameManager.instance.isAlbum;
        _gameData.num = GameManager.instance.num;

        string ToJsonData = JsonUtility.ToJson(gameData);
        string filepath = Application.persistentDataPath + "/" + GameDataFileName;
        File.WriteAllText(filepath, ToJsonData);
        Debug.Log("저장에 성공했다....");
    }

    public void SaveSceneName(string sceneName)
    {
        _gameData.previousSceneName = sceneName;
        SaveGameData();
    }

    public void LoadSavedScene()
    {
        LoadGameData();
        if (!string.IsNullOrEmpty(_gameData.previousSceneName))
        {
            SceneManager.LoadScene(_gameData.previousSceneName);
        }
        else
        {
            Debug.LogWarning("저장된 씬 이름이 없습니다.");
        }
    }

    public void ExitGame()
    {
        Debug.Log("게임 종료 중...");
        Application.Quit();
    }
}


