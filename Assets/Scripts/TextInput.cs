using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public InputField codeInput;
    public string code;
    public string nextScene;
    public int mobnum;

    void next() {
        SceneManager.LoadScene(nextScene);
    }
    private void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Return)) {
            if(codeInput.text.Length > 0) {
                if(codeInput.text == code) SceneManager.LoadScene(nextScene);
                else {
                    GameManager.instance.num = mobnum;
                    SceneManager.LoadScene("EndingScene");
                }
            }
        }
    }
}
