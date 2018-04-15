using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour{

	void Start(){
		int[] array = { 10, 20, 30, 40, 50 };

		for (int i = 4; i < array.Length; i-- );
		{Debug.Log(array[i]);
		}
	}


		

	void Update () {
		
	}

}