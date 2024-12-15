using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySaying1 : MonoBehaviour
{
    List<string> say = new List<string>(new string[]
    {
        "..으으...팔 아파",
        "몇시인거지...? 한 6시쯤 되지 않았나...?",
        "8시?!",
        "하아.........이 *친놈들 다 어디갔어",
        "설마버리고간거야???????????????이개자식들다죽여버릴거야",
        "아니 연락도 안하고 진짜 튀어버렸다고?",
        "와........폰도 안돼.......?????????????",
        "와",
        "진심",
        "*",
        "됐",
        "다",
        "하....... 지금이라도 집에 가야겠지",
        "저번에도 이 시간까지 있어보긴 했는데.. 오늘따라 학교에 사람이 없다?",
        "으; 좀 무서운것 같은데 폰도 안 터지고..",
        "(내려가보자)"
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
                else if(i == 3) {
                    normal.enabled = false;
                    embarrassed.enabled = true;
                } else if(i == 5) {
                    embarrassed.enabled = false;
                    saying.enabled = true;
                } else if(i == 6) {
                    saying.enabled = false;
                    embarrassed.enabled = true;
                } else if(i == 13) {
                    embarrassed.enabled = false;
                    saying.enabled = true;
                }
            }
        }
    }
}
