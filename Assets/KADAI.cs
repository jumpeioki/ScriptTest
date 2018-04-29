using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KADAI : MonoBehaviour {


	// Use this for initialization
	void Start ()
	{
		int[] array = { 10, 20, 30, 40, 50 };
		for (int i = 0; i < 5; i++) 
		{
			Debug.Log (array [i]);
		}
		for (int i = 4; i > -1; i--)
		{
		Debug.Log (array [i]);
	}
}
		
	// Update is called once per frame
	void Update () {
		
	}
}
