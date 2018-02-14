using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private void Update()
    {
        transform.LookAt(_player.transform);
    }
}