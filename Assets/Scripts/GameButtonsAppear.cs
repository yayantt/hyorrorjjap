using UnityEngine;

public class GameButtonsAppear : MonoBehaviour
{
    void Awake()
    {   
        if(GameManager.instance.isTalkedWithDarae == false) this.gameObject.SetActive(false);
    }
}
