using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingStorySaying : MonoBehaviour
{
    List<string> say = new List<string>(new string[]
    {
        "그래.. 다 모아 왔구나",
        "마지막으로 하나만 물어볼게.",
        "이름이 뭐야"
    });
    public TextMeshProUGUI text;
    public InputField codeInput;
    public SpriteRenderer wall;
    int i = 0;
    void Start()
    {
        text.text = "";
        wall.enabled = true;
    }
    void Update()
    {   
        if(i != say.Count) {
            if(Input.GetKeyDown(KeyCode.E)) {
                text.text = say[i];
                i++;
                if(i == say.Count) {
                    wall.enabled = false;
                }
            }
        } else {
            if(Input.GetKeyDown(KeyCode.Return)) {
                if(codeInput.text.Length > 0) {
                    text.fontSize = 12;
                    if(codeInput.text == "진언" || codeInput.text == "서진언") {
                        GameManager.instance.num = 5;
                        text.text = "..아 그치? 너 이름 서진언맞지? ^^";
                        SceneManager.LoadScene("EndingScene");
                    } else if(codeInput.text == "하늘") {
                        GameManager.instance.num = 6;
                        text.text = "? 네가 내 이름을 어떻게..";
                        SceneManager.LoadScene("EndingScene");
                    } else if(codeInput.text == "승희" || codeInput.text == "한승희") {
                        text.text = "안어려웠냐? 다시 입력해보셈";
                    } else if(codeInput.text == "서연" || codeInput.text == "양서연") {
                        text.text = "그림쟁이 쉒";
                    } else if(codeInput.text == "민수" || codeInput.text == "박민수") {
                        text.fontSize = (float)5.5;
                        text.text = "언더테일 아시는구나! 혹시 모르시는분들에 대해 설명해드립니다 샌즈랑 언더테일의 세가지 엔딩루트중 몰살엔딩의 최종보스로 진.짜.겁.나.어.렵.습.니.다 공격은 전부다 회피하고 만피가 92인데 샌즈의 공격은 1초당 60이 다는데다가 독뎀까지 추가로 붙어있습니다.. 하지만 이러면 절대로 게임을 깰 수 가없으니 제작진이 치명적인 약점을 만들었죠. 샌즈의 치명적인 약점이 바로 지친다는것입니다. 패턴들을 다 견디고나면 지쳐서 자신의 턴을 유지한채로 잠에듭니다. 하지만 잠이들었을때 창을옮겨서 공격을 시도하고 샌즈는 1차공격은 피하지만 그 후에 바로날아오는 2차 공격을 맞고 죽습니다.";
                    } else if(codeInput.text == "샌즈" || codeInput.text == "와 샌즈") {
                        text.text = "아시는구나!!";
                    } else {
                        text.text = "흠... 내가 모르는 이름인걸..? 다시 입력해볼래?";
                    }
                }
            }
        }
    }
}