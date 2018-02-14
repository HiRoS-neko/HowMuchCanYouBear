using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTip : MonoBehaviour
{
    [SerializeField] private MainGUI _guiElement;
    
    public void EnterHide()
    {
        _guiElement.DisplayTip("Hold Shift To Hide");
    }

    public void Hiding()
    {
        _guiElement.DisplayTip("Release Shift To Stop Hiding");
    }

    public void ResetTip()
    {
        _guiElement.ResetTip();
    }

    public void DebugTip(string tip)
    {
        _guiElement.DisplayTip(tip);
    }
}