using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector2 minCameraBoundary;
    [SerializeField] Vector2 maxCameraBoundary;
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minCameraBoundary.x, maxCameraBoundary.x), Mathf.Clamp(player.position.y, minCameraBoundary.y, maxCameraBoundary.y), this.transform.position.z);
    }
}
