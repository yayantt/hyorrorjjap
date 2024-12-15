using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySaying2 : MonoBehaviour
{
    List<string> say = new List<string>(new string[]
    {
        "?뭐야",
        "문이  왜 잠겨있지?",
        "(다시 올라가볼까?)"
    });
    public TextMeshProUGUI text;
    public SpriteRenderer normal;
    public SpriteRenderer saying;
    public SpriteRenderer embarrassed;
    public string nextScene;
    int i = 0;
    void Start()
    {
        text.text = "";
        normal.enabled = false;
        saying.enabled = false;
        embarrassed.enabled = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if(i == say.Count) {
                SceneManager.LoadScene(nextScene);
            } else {
                text.text = say[i];
                i++;
                if(i == 1) normal.enabled = true;
                else if(i == 2) {
                    normal.enabled = false;
                    embarrassed.enabled = true;
                }
            }
        }
    }
}
