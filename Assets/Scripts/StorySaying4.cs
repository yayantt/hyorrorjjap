using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySaying4 : MonoBehaviour
{
    List<string> say = new List<string>(new string[]
    {
        "여긴 왜 이렇게 어두워...",
        "설마 뭐 나오는거 아니겠지..?",
        "",
        "..",
        "★빠밤★",
        "으악!!!!!!!!!!!!!!",
        "(도망치면서 물건을 빠르게 챙겼다)"
    });
    public TextMeshProUGUI text;
    public SpriteRenderer embarrassed;
    public SpriteRenderer background;
    public string nextScene;
    int i = 0;
    void Start()
    {
        text.text = "";
        embarrassed.enabled = false;
        background.enabled = true;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if(i == say.Count) {
                SceneManager.LoadScene(nextScene);
            } else {
                text.text = say[i];
                i++;
                if(i == 1) embarrassed.enabled = true;
                else if(i == 3) embarrassed.enabled = false;
                else if(i == 5) background.enabled = false;
                else if(i == 6) embarrassed.enabled = true;
                else if(i == 7) embarrassed.enabled = false;
            }
        }
    }
}
