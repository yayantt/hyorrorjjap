using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int mobnum;
    public float time;
 
    private void Update () {
        if (time > 0) time -= Time.deltaTime;
        else {
            GameManager.instance.num = mobnum;
            SceneManager.LoadScene("EndingScene");
        }
 
        timeText.text = Mathf.Ceil(time).ToString();
    }
}
