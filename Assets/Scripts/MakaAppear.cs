using UnityEngine;

public class MakaAppear : MonoBehaviour
{
    void Awake()
    {   
        this.gameObject.SetActive(GameManager.instance.isMaka);
    }
}
