using UnityEngine;

public class MousePointer : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        transform.position = 10*Input.mousePosition / Screen.height;
    }
}
