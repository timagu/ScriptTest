using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	int mp = 53;
	// Use this for initialization
	void Magic () {
		mp-=5;
		if (mp>5){
			Debug.Log("魔法攻撃をした。残りMPは、" + mp);
		}else{
			Debug.Log("魔法攻撃をした。残りMPは、" + mp);
			Debug.Log("MPが足りないため魔法を使えない。");
		}
		
	}
	
	// Update is called once per frame
	void Start () {
		for (int i = 0; i < 10; i++){
			Magic ();
		}
		Magic ();
		if (this.mp>5){
			Debug.Log("魔法攻撃をした。残りMPは、" + this.mp);
		}else{
			Debug.Log("MPが足りないため魔法を使えない。");
		}
	}
}
