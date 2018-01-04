using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeAttack : MonoBehaviour {
	

	[SerializeField]
	private Animator animator;
	[SerializeField]
	private PlayerJoystick playerJoys;

	void Start () {
		
	}
	

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player"){
			playerJoys.enabled = false;
			StartCoroutine(DeathAnim());
			StartCoroutine (RestartGame ());
		}
	}

	IEnumerator DeathAnim(){
		yield return new WaitForSeconds (0.1f);
		animator.SetInteger ("PlayerAnim", 10);
	}

	IEnumerator RestartGame(){
		yield return new WaitForSeconds (1.2f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
