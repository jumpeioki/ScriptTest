using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        

	private int mp = 53;

		public void Magic(){
		mp -= 5;
		if (mp >= 0) {
			Debug.Log ("魔法攻撃をした.残りMPは"+ mp);
		} else {Debug.Log ("MPが足りないため魔法が使えない");
			
		}
	}
}


public class HTTENKADAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss lastaoss = new Boss ();
		for(int i =1; i<11; i++)
		{lastaoss.Magic ();}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
