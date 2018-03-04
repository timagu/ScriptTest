using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// 「Hello, UnityChan」と表示する関数
	void Goodbye(){
		Debug.Log ("Goodbye, UnityChan");
	}

	void Start () {
		//hello関数を呼び出す
		Goodbye();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
