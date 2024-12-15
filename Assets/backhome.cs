using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  
    public void MoveToStartScene()
    {
        SceneManager.LoadScene("StartScene");
        Debug.Log("�� �̵�: StartScene");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
        Debug.Log("���� ����");
    }
}


