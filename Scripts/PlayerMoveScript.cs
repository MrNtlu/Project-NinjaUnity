using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoveScript : MonoBehaviour {
	[SerializeField]
	private Transform[] groundPoints;
	[SerializeField]
	private float groundRadius;
	[SerializeField]
	private LayerMask whatisGround;

	private bool isgrounded;

	private bool jump;
	[SerializeField]
	private float jumpForce;

	public float speed=8f,maxVelocity =4f;
	[SerializeField]
	private Rigidbody2D myBody;
	private Animator anim;

	public float h;
	public float d;

	void Awake () {
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate () {
		PlayerMove ();
		isgrounded = isGrounded ();
	}

	public void PlayerMove () {
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);
		//float vel2 = Mathf.Abs (myBody.velocity.y);

		float h = Input.GetAxisRaw ("Horizontal");
		float d = Input.GetAxisRaw ("Vertical");

		if (h > 0) {///h>0
			if (vel < maxVelocity)
				forceX = speed;
			Vector3 temp = transform.localScale;
			temp.x = 0.2f;
			transform.localScale = temp;
			anim.SetInteger ("PlayerAnim", 1);
		} else if (h < 0) {
			if (vel < maxVelocity)
				forceX = -speed;
			Vector3 temp = transform.localScale;
			temp.x = -0.2f;
			transform.localScale = temp;
			anim.SetInteger ("PlayerAnim", 1);

		} else if(d>0){
			jump = true;
			if (isgrounded && jump) {
				isgrounded = false;
				myBody.AddForce (new Vector2 (0, jumpForce));
			}
			//myBody.AddForce (new Vector2 (0f, 25f));
		}else{
			anim.SetInteger ("PlayerAnim", 2);
		}
		myBody.AddForce (new Vector2 (forceX, 0));

	}




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
