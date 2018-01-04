using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerJoystick : MonoBehaviour {
	[SerializeField]
	private Transform[] groundPoints;
	[SerializeField]
	private float groundRadius;
	[SerializeField]
	private LayerMask whatisGround;

	private bool isgrounded;

	public bool moveLeft, moveRight, moveJump, moveAttack;

	private bool jump;
	[SerializeField]
	private float jumpForce;

	public float speed=8f,maxVelocity =4f;
	[SerializeField]
	private Rigidbody2D myBody;
	private Animator anim;


	void Awake () {
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate () {
		if (moveLeft) {
			MoveLeft ();
		}
		if (moveRight) {
			MoveRight ();
		}
		if (moveJump) {
			MoveJump ();
		}
		if (moveAttack) {
			MoveAttack ();
		}
		isgrounded = isGrounded ();
	}

	public void SetMoveLeft(bool moveLeft){
		this.moveLeft = moveLeft;
		this.moveRight = !moveLeft;
		///this.MoveJump = moveJump;
	}

	public void SetMoveRight(bool moveRight){
		this.moveRight = moveRight;
		///this.MoveJump = moveJump;
	}
		
	public void SetMoveJump(bool moveJump){
		this.moveJump = moveJump;
		///this.MoveJump = moveJump;
	}

	public void SetMoveAttack(bool moveAttack){
		this.moveAttack = moveAttack;
		///this.MoveJump = moveJump;
	}

	public void StopMoving(){
		moveLeft = moveRight = moveJump = moveAttack = false;
		anim.SetInteger ("PlayerAnim", 2);
	}

	void MoveAttack(){
		anim.SetInteger("PlayerAnim",3);
	}

	void MoveLeft(){
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);
		if (vel < maxVelocity)
			forceX = -speed;
		Vector3 temp = transform.localScale;
		temp.x = -0.2f;
		transform.localScale = temp;
		anim.SetInteger ("PlayerAnim", 1);
		myBody.AddForce (new Vector2 (forceX, 0));
	}
	void MoveRight(){
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);
		if (vel < maxVelocity)
			forceX = speed;
		Vector3 temp = transform.localScale;
		temp.x = 0.2f;
		transform.localScale = temp;
		anim.SetInteger ("PlayerAnim", 1);
		myBody.AddForce (new Vector2 (forceX, 0));
	}


	void MoveJump (){
		jump = true;
		if (isgrounded && jump) {
			isgrounded = false;
			myBody.AddForce (new Vector2 (0, jumpForce));
		}
	}

	//myBody.AddForce (new Vector2 (forceX, 0));

	private bool isGrounded(){
		if (myBody.velocity.y <= 0) {
			foreach (Transform point in groundPoints) {
				Collider2D[] colliders = Physics2D.OverlapCircleAll (point.position, groundRadius, whatisGround);

				for (int i = 0; i < colliders.Length; i++) {
					if(colliders[i].gameObject!=gameObject){
						return true;
					}
				}
			}
		}
		return false;
	}
}
