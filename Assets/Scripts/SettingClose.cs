using UnityEngine;
using UnityEngine.UI;

public class SettingClose : MonoBehaviour
{
    public GameObject settings;
    public Button button;
    void Start()
    {   
        button.onClick.AddListener(Close);
    }
    
    void Close() {
        settings.SetActive(false);
    }
}
