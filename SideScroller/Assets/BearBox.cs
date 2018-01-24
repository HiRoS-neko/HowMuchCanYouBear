using System;
using System.Text;
using UnityEngine;

public class BearBox : MonoBehaviour
{
    private CharacterSelect _cs;

    private bool _select;

    // Use this for initialization
    void Start()
    {
        _cs = GetComponentInParent<CharacterSelect>();
    }

    private void OnMouseDown()
    {
        if (_select == false)
            _cs.Selected(this);
    }

    // Update is called once per frame

    public void Select()
    {
        _select = true;

        //Trigger selected animation
    }

    public void Deselect()
    {
        _select = false;

        //Trigger deselected animation
    }
}