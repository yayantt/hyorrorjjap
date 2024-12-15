using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  
    public void MoveToStartScene()
    {
        SceneManager.LoadScene("StartScene");
        Debug.Log("씬 이동: StartScene");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
        Debug.Log("게임 종료");
    }
}


