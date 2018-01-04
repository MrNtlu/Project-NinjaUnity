using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePointController : MonoBehaviour {

	[SerializeField]
	private BoxCollider2D sidepoint, sidepoint2;
	[SerializeField]
	private PlayerJoystick playerJoy;

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Ground") {
			//playerJoy.moveRight = false;
			playerJoy.moveLeft = false;
		}
	}
	

}
