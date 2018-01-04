using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossAttackLeft : MonoBehaviour {
	[SerializeField]
	private GameObject Boss;

	[SerializeField]
	private Animator anim;


	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			anim.SetInteger ("BossAnim", 2);
			Boss.transform.eulerAngles = new Vector2 (0, 180);
			StartCoroutine (RestartAnim ());
		} 
	}

	IEnumerator RestartAnim(){
		yield return new WaitForSeconds (2);
		anim.SetInteger ("BossAnim", 0);
	}

}
