using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour,IPointerDownHandler, IPointerUpHandler {
	[SerializeField]
	private Animator anim;
	private PlayerJoystick playerJoy;

	void Start () {
		playerJoy = GameObject.Find ("Player").GetComponent<PlayerJoystick> ();
	}

	public void OnPointerDown (PointerEventData data) {
		if (gameObject.name == "LeftButton") {
			playerJoy.SetMoveLeft (true);

		} else if (gameObject.name == "RightButton") {
			playerJoy.SetMoveRight (true);


		} ///else if (gameObject.name == "JumpButton") {
			///playerJoy.SetMoveJump (true);

		///}
		///else if (gameObject.name == "AttackButton") {
			///playerJoy.SetMoveAttack (true);

		///}
	}


	public void OnPointerUp(PointerEventData data){
		playerJoy.StopMoving ();
	}

}
