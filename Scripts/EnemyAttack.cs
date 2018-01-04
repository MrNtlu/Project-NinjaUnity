using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour {
	[SerializeField]
	private PolygonCollider2D playerWeapon2;

	[SerializeField]
	private GameObject enemy;

	[SerializeField]
	private Animator anim;
	[SerializeField]
	private PlayerJoystick playerJoy;

	void Start () {
		
	}
	

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player"){
			//playerWeapon2.enabled = false;
			playerJoy.enabled = false;
			///anim.SetInteger ("PlayerAnim", 10);
			StartCoroutine(DeathAnim());
			StartCoroutine (RestartGame ());
		}
	}

	IEnumerator DeathAnim(){
		yield return new WaitForSeconds (0.1f);
		anim.SetInteger ("PlayerAnim", 10);
	}

	IEnumerator RestartGame(){
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
