using System;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Light))]
public class Flicker : MonoBehaviour
{

	private Light _light;
	
	// Use this for initialization
	void Start ()
	{
		_light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Random.Range(0, 7) == 2)
		{
			_light.intensity = (float) Math.Abs(Math.Sin(8*Time.time)) * 16;
		}
		
	}
}
