using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST2 : MonoBehaviour {

	public class Boss
	{
		int mp = 53;

		public void Magic(int point){
			mp -= point;
			if (mp > 0) {
				Debug.Log ("魔法攻撃をした.残りＭＰは" + mp);
			}else
			{Debug.Log ("MPが足りないため魔法が使えない");
			}
		}
	}
	void Start () {

		Boss lastboss = new Boss ();

		for (int i = 0; i <= 10; i ++) {
			lastboss.Magic(5);}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
