using UnityEngine;
using System.Collections;

public class InputStateWithMove : MonoBehaviour {

	public bool actionButton=false;
	public bool moveLeft=false;
	public bool moveRight=false;


	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;

	private Rigidbody2D body2d;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//actionButton = Input.anyKeyDown;
		actionButton = Input.GetKey (KeyCode.Space);
		moveLeft = Input.GetKey (KeyCode.A);
		moveRight = Input.GetKey (KeyCode.D);
	}

	void FixedUpdate(){
		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);

		standing = absVelY <= standingThreshold;
	}
}
