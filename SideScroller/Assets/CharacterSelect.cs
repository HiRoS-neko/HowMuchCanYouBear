using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{

	[SerializeField] private BearBox[] _bearBoxes;


	[SerializeField] private int _selectedIndex;

	public void Selected(BearBox selected)
	{
		for (int i = 0; i < _bearBoxes.Length; i ++)
		{
			if (_bearBoxes[i] == selected)
			{
				_bearBoxes[i].Select();
				_selectedIndex = i;
			}
			else
			{
				_bearBoxes[i].Deselect();
			}
			
		}
	}
}
