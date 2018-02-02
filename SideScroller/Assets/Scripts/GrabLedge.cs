using UnityEngine;


[RequireComponent(typeof(CharacterMotor), typeof(PlayerMove), typeof(Rigidbody))]
public class GrabLedge : MonoBehaviour
{

    private CharacterMotor _playerMotor;
    private PlayerMove _playerMove;
    private Rigidbody _rigid;
    private Animator _anim;
    
    private void Start()
    {
        _playerMotor = GetComponent<CharacterMotor>();
        _playerMove = GetComponent<PlayerMove>();
        _rigid = GetComponent<Rigidbody>();
        _anim = GetComponentInChildren<Animator>();
    }

    public void StartHold(Vector3 pos, int dir)
    {
        
        _playerMove.enabled = false;
        _playerMotor.enabled = false;
        _rigid.velocity = Vector3.zero;
        _rigid.useGravity = false;
        _anim.SetBool("LedgeGrab", true);
        this.transform.position = pos - dir*new Vector3(0.65f, 1.2f, 0);
        
    }

    public void StopJumpHold()
    {
    //player jumped while holding... big jump
        _playerMove.enabled = true;
        _playerMotor.enabled = true;
        _rigid.useGravity = true;
        _anim.SetBool("LedgeGrab", false);
        
        _playerMove.Jump(Vector3.up*25);

    }

    public void StopHold()
    {
        
        //player let go drop hhim
        _playerMove.enabled = true;
        _playerMotor.enabled = true;        
        _rigid.useGravity = true;
        _anim.SetBool("LedgeGrab", false);
        _anim.SetTrigger("Falling");



    }
}