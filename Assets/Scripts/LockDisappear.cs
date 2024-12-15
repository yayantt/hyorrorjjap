using UnityEngine;

public class LockDisappear : MonoBehaviour
{
    void Awake()
    {
        if(GameManager.instance.isLockedChecked) this.gameObject.SetActive(false);
    }
}
