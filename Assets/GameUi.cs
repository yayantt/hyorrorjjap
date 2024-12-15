using UnityEngine;

public class GameUi : MonoBehaviour
{

    public void OnLoadButtonClicked()
    {
        DataController.instance.LoadSavedScene();
    }

}
