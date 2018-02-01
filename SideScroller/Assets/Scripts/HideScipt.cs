﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScipt : MonoBehaviour
{

	public enum HideType
	{
		Wardrobe,
		Box,
	}

	[SerializeField] private HideType _hideType;

	private bool _hiding;


	private void OnTriggerStay(Collider other)
	{
		if (Input.GetAxis("Interact") == 1 && other.gameObject.CompareTag("Player") && !_hiding)
		{
			_hiding = true;
			other.GetComponent<PlayerHide>().StartHiding();
		}
		else if (_hiding && Input.GetAxis("Interact") == 0)
		{
			_hiding = false;
			other.GetComponent<PlayerHide>().StopHiding();
		}
	}
}
