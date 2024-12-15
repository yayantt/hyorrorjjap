using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySaying3 : MonoBehaviour
{
    List<string> say = new List<string>(new string[]
    {
        "(복도를 걷던 중, 노트를 보고 있는 여자애를 발견했다)",
        "...얘도 갇혔나?",
        "저기.. 혹시 학교 나가는 법 알고있니.......?",
        "출구로 나가봤는데 문도 잠겨있고, 뭔 이상한 사람도 있어서..",
        "...사람? 3년만에 보는건가..",  // . : 다래
        "좀 안타깝긴 한데, 여긴 네가 알던 학교가 아닐걸?",  // .
        "여긴 좀 다른 학교라고 생각해, 음.. 귀신이 있는 학교 같은거지. 네가 아까 봤다던 사람도 귀신일걸..",    // .
        "어??????????",
        "너무 놀라지는 마, 나가는 방법은 있으니까.",    // .
        "그리 어렵지도 않을걸? 재료만 모으면 끝이니까.",    // .
        "..뭘 모아야 하는데?",
        "교실에 있는 보드마카랑, 교무실에 있는 졸업앨범, 그리고.. 라이터만 있으면 될거야.", // .
        "여기가 그닥 즐겁지는 않은 곳이니까, 가져다 주면 빨리 나갈 수 있게 내가 도와줄게.", // .
        "그보다 같이 가줄수는 없는거야?",
        "뭐, 나도 해야하는 일이 있으니까? 대신 이거라도 줄게. 귀신이 나오면 도망칠 수는 있을 거야", // .
        "(노트를 건내줬다. 작은 글씨로 ‘다래’라고 쓰여져 있다)",
        "이름이 다래구나... 으으... 빨리 다녀와야지.."
    });
    public TextMeshProUGUI text;
    public SpriteRenderer normal;
    public SpriteRenderer saying;
    public SpriteRenderer embarrassed;
    public SpriteRenderer background1;
    public SpriteRenderer background2;
    public SpriteRenderer darae;
    public string nextScene;
    int i = 0;
    void Start()
    {
        text.text = "";
        normal.enabled = false;
        saying.enabled = false;
        embarrassed.enabled = false;
        background1.enabled = true;
        background2.enabled = false;
        darae.enabled = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if(i == say.Count) {
                SceneManager.LoadScene(nextScene);
            } else {
                text.text = say[i];
                i++;
                if(i == 2) normal.enabled = true;
                else if(i == 3) {
                    normal.enabled = false;
                    saying.enabled = true;
                } else if(i == 5) {
                    saying.enabled = false;
                    normal.enabled = true;
                    background1.enabled = false;
                    background2.enabled = true;
                    darae.enabled = true;
                } else if(i == 8) {
                    normal.enabled = false;
                    embarrassed.enabled = true;
                } else if(i == 9) {
                    embarrassed.enabled = false;
                    normal.enabled = true;
                } else if(i == 11) {
                    normal.enabled = false;
                    saying.enabled = true;
                } else if(i == 12) {
                    saying.enabled = false;
                    normal.enabled = true;
                } else if(i == 14) {
                    normal.enabled = false;
                    embarrassed.enabled = true;
                } else if(i == 15) {
                    embarrassed.enabled = false;
                    normal.enabled = true;
                } else if(i == 16) {
                    normal.enabled = false;
                    darae.enabled = false;
                } else if(i == 17) normal.enabled = true;
            }
        }
    }
}
