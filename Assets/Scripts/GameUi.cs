using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public void OnLoadSavedSceneButtonClicked()
    {
        DataController.instance.LoadSavedScene();
    }

    public void MoveToStartScene()
    {
        SceneManager.LoadScene("StartScene");
        Debug.Log(" StartScene");
    }

    public void ExitGame() 
    {
        Debug.Log("���� ���� ��..."); 
        Application.Quit(); 
    }
}

