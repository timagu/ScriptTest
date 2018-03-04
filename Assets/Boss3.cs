using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3 : MonoBehaviour {
	int hp = 100;	//体力
	int power = 25;	//攻撃力

	public void Attack () {
		//攻撃用の関数
		Debug.Log(this.power + "のダメージを与えた");
	}

	public void Defence (int damage) {
		//防御用の関数
		Debug.Log(damage + "のダメージを受けた");
		//残りhpを減らす。
		this.hp -= damage;
		Debug.Log ("HP:"+this.hp);
	}
}

public class Boss2 : MonoBehaviour{

	void Start(){
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss3 lastboss = new Boss3();

		//攻撃用の関数をよびだす
		lastboss.Attack();
		//防御用の関数をよびだす
		lastboss.Defence(3);
	}

	//Update is called once per frame
	void Update (){
		
	}
}