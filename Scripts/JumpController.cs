using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpController : MonoBehaviour,IPointerDownHandler, IPointerUpHandler {
	[SerializeField]
	private Animator anim;
	private PlayerJoystick playerJoy;

	void Start () {
		playerJoy = GameObject.Find ("Player").GetComponent<PlayerJoystick> ();
	}

	public void OnPointerDown (PointerEventData data) {
		if (gameObject.name == "JumpButton") {
			playerJoy.SetMoveJump (true);
			anim.SetInteger ("PlayerAnim", 7);
		}
	}


	public void OnPointerUp(PointerEventData data){
		if (playerJoy.moveRight == true) {
			playerJoy.SetMoveRight (true);
			playerJoy.SetMoveJump (false);
		} else if (playerJoy.moveLeft == true) {
			playerJoy.SetMoveLeft (true);
			playerJoy.SetMoveJump (false);
		} else {
			playerJoy.StopMoving ();
			
		}
	}

}
