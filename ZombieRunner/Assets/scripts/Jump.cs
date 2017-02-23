using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpSpeed = 240f;
	public float forwardSpeed = 20;

	private Rigidbody2D body2d;
	private InputState inputState;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}

	// Update is called once per frame
	void Update () {

		if (inputState.standing==true) {
			if(inputState.actionButton==true){
				body2d.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
			}

		}

		if(inputState.moveLeft==true){
			body2d.velocity = new Vector2(-95, body2d.velocity.y);
		}
		if(inputState.moveRight==true){
			body2d.velocity = new Vector2(95,  body2d.velocity.y);
		}

	}
}
