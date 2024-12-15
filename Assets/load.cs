using UnityEngine;

public class load : MonoBehaviour
{

    public void OnLoadButtonClicked() 
    { 
        DataController.instance.LoadSavedScene();
    }

}
