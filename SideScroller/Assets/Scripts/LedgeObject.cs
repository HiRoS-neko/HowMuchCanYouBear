using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LedgeObject : MonoBehaviour
{
    private Collider _trigger;
    private bool _hanging;

    [SerializeField, Range(-1, 1)] private int _direction;

    private void Start()
    {
        _trigger = GetComponent<Collider>();

        if (_trigger.isTrigger == false)
        {
            Debug.Log("Collider on " + name + " must be a collider");
            _trigger.isTrigger = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (_hanging == false && other.gameObject.CompareTag("Player") && Input.GetAxis("Interact") == 1)
        {
            _hanging = true;
            other.GetComponent<GrabLedge>().StartHold(this.transform.position, _direction);
        }
        else if (_hanging && other.gameObject.CompareTag("Player") && Input.GetAxis("Jump") == 1)
        {
            _hanging = false;
            other.GetComponent<GrabLedge>().StopJumpHold();
        }
        else if (_hanging && other.gameObject.CompareTag("Player") && Input.GetAxis("Interact") == 0)
        {
            _hanging = false;
            other.GetComponent<GrabLedge>().StopHold();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_hanging && other.gameObject.CompareTag("Player"))
        {
            _hanging = false;
            other.GetComponent<GrabLedge>().StopHold();
        }
    }
}