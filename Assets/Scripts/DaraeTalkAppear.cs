using UnityEngine;

public class DaraeTalkAppear : MonoBehaviour
{
    void Awake()
    {
        if(GameManager.instance.isLockedChecked == false || GameManager.instance.isTalkedWithDarae) this.gameObject.SetActive(false);
    }
}
