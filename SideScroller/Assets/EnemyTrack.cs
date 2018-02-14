using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrack : MonoBehaviour
{
    [SerializeField] private GameObject _point1;
    [SerializeField] private GameObject _point2;


    private Vector3 _target;
    [SerializeField] private float _speed;

    // Use this for initialization
    void Start()
    {
        transform.position = _point1.transform.position;
        _target = _point2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Magnitude(transform.position - _target) < 0.1)
            _target = Vector3.Magnitude(_target - _point1.transform.position) < 0.1 ? _point2.transform.position : _point1.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }
}