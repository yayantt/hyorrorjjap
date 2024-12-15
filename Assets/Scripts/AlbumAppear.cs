using UnityEngine;

public class AlbumAppear : MonoBehaviour
{
    void Awake()
    {   
        this.gameObject.SetActive(GameManager.instance.isAlbum);
    }
}
