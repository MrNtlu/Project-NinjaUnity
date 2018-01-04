using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackJoystickController : MonoBehaviour,IPointerDownHandler, IPointerUpHandler {
	[SerializeField]
	private Animator anim;
	private PlayerJoystick playerJoy;


	void Start () {
		playerJoy = GameObject.Find ("Player").GetComponent<PlayerJoystick> ();
	}



	public void OnPointerDown (PointerEventData data) {
		if (gameObject.name == "AttackButton") {
			playerJoy.SetMoveAttack (true);

		}
	}


	public void OnPointerUp(PointerEventData data){
		if (playerJoy.moveRight == true) {
			playerJoy.SetMoveRight (true);
			playerJoy.SetMoveAttack (false);
		} else if (playerJoy.moveLeft == true) {
			playerJoy.SetMoveLeft (true);
			playerJoy.SetMoveAttack (false);
		} else {
			playerJoy.StopMoving ();
			
		}
	}

}
