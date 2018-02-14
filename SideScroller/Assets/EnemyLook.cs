using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    [SerializeField] private GameObject _target;



    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_target.transform);
    }
}