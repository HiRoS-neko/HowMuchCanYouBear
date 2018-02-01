using UnityEngine;

[RequireComponent(typeof(CharacterMotor), typeof(PlayerMove), typeof(Rigidbody))]
public class PlayerHide : MonoBehaviour
{
    private Animator _animator;
    
    private PlayerMove _playerMove;
    private CharacterMotor _playerMotor;
    private Rigidbody _rigid;

    private float _distance = 4;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMove = GetComponent<PlayerMove>();
        _playerMotor = GetComponent<CharacterMotor>();
        _rigid = GetComponent<Rigidbody>();
    }

    public void StartHiding()
    {
        _playerMove.enabled = false; //while hiding disable player movement
        _playerMotor.enabled = false;
        _rigid.velocity = Vector3.zero;
        this.transform.position += Vector3.forward*_distance;
    }

    public void StopHiding()
    {
        _playerMove.enabled = true; //reenable player move       
        _playerMotor.enabled = true;

        this.transform.position -= Vector3.forward*_distance;
    }
}