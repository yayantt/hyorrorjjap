using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    // 0 : 시작 -> 3층
    // 3 : 3층 -> 2층
    // 4 : 3층 <- 2층
    // 5 : 2층 -> 1층
    // 6 : 2층 <- 1층
    // 8 : 잠긴거 확인
    // 9 : 다래 첫 대면
    public int previousScene = 0;
    public bool isLockedChecked = false;
    public bool isTalkedWithDarae = false;
    public bool isLighter = false;
    public bool isMaka = false;
    public bool isAlbum = false;
    public int num = 0;

    private void Awake()
    {
        if(instance != null) Destroy(this);
        else instance = this;
    }
}
