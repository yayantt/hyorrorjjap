using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToStart : MonoBehaviour
{
    public Button button;
    void Start() {
        button.onClick.AddListener(OpenScene);
    }
    
    void OpenScene() {
        SceneManager.LoadScene("StoryScene_1");
    }
}
