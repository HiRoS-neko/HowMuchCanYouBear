﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour {
	public void MouseClick()
	{
		//TODO store players selection
		SceneManager.LoadScene("Level1");
	}
}
