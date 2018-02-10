using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LedgeObject : MonoBehaviour
{
    private enum Direction
    {
        left,
        right
    }

    private Collider _trigger;
    private bool _hanging;

    [SerializeField] private Direction _direction;

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
            switch (_direction)
            {
                case Direction.left:
                    other.GetComponent<GrabLedge>().StartHold(this.transform.position - new Vector3(0.65f, 1.2f, 0), false);
                    break;
                case Direction.right:
                    other.GetComponent<GrabLedge>().StartHold(this.transform.position - new Vector3(-0.65f, 1.2f, -0), true);
                    break;
            }
            
        }
        else if (_hanging && other.gameObject.CompareTag("Player") && Input.GetAxis("Jump") == 1)
        {
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