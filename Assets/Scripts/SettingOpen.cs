using UnityEngine;
using UnityEngine.UI;

public class SettingOpen : MonoBehaviour
{
    public GameObject settings;
    public Button button;
    void Start()
    {   
        button.onClick.AddListener(Open);
    }
    
    void Open() {
        settings.SetActive(true);
    }
}
