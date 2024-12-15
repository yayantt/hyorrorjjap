using UnityEngine;

public class Ending : MonoBehaviour
{
    public SpriteRenderer background1;
    public SpriteRenderer background2;
    public SpriteRenderer background3;
    public SpriteRenderer background4;
    public SpriteRenderer background5;
    public SpriteRenderer background6;
    void Awake()
    {
        background1.enabled = false;
        background2.enabled = false;
        background3.enabled = false;
        background4.enabled = false;
        background5.enabled = false;
        background6.enabled = false;
    }
    void Start()
    {
        int ex = GameManager.instance.num;
        if(ex == 1) background1.enabled = true;
        else if(ex == 2) background2.enabled = true;
        else if(ex == 3) background3.enabled = true;
        else if(ex == 4) background4.enabled = true;
        else if(ex == 5) background5.enabled = true;
        else if(ex == 6) background6.enabled = true;
    }
}
