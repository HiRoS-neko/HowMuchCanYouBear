using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainGUI : MonoBehaviour
{

	[SerializeField] private TextMeshProUGUI _displayTip;
	

	public void DisplayTip(string tip)
	{
		_displayTip.text = tip;
	}
	
	public void ResetTip()
	{
		_displayTip.text = "";
	}
}
