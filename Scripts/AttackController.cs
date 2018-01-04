using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour {
	[SerializeField]
	private GameObject enemy;
	[SerializeField]
	private GameObject boss;

	[SerializeField]
	private PolygonCollider2D enemyweapon,EnemyBossWeapon,EnemyBossWeapon2;


	[SerializeField]
	private BoxCollider2D enemybossCollider,enemyCollider;

	[SerializeField]
	private Animator anim,anim2;

	void Start () {

	}
	

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Enemy"){
			anim.SetInteger ("EnemyAnim", 2);
			enemyCollider.enabled = false;
			StartCoroutine (SetActiveEnemy ());
		}

		if (coll.gameObject.tag == "EnemyBoss") {
			enemybossCollider.enabled = false;
			anim2.SetInteger ("BossAnim", 3);
			StartCoroutine (SetActiveBoss ());
		}
	}

	IEnumerator SetActiveEnemy(){
		yield return new WaitForSeconds (2f);
		enemy.SetActive (false);
	}
	IEnumerator SetActiveBoss(){
		yield return new WaitForSeconds (2f);
		boss.SetActive (false);
	}

}
