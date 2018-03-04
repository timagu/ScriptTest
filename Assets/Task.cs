using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//配列arrayの表示
		int[] array={10,23,45,55,60};

		for(int i = 0; i < array.Length; i++){
			//Debug.Log ("配列の長さ："+array.Length);
			//Debug.Log ("アドレス"+i);
			Debug.Log (array[i]);
		}

		//配列arrayの表示を逆順に
		for(int j = array.Length-1; j > -1; j--){
			//Debug.Log ("アドレス"+j);
			Debug.Log (array[j]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
