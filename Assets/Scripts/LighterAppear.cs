using UnityEngine;

public class LighterAppear : MonoBehaviour
{
    void Awake()
    {   
        this.gameObject.SetActive(GameManager.instance.isLighter);
    }
}
