using UnityEngine;
using System.Collections;

public class PlayerAnimationManager : MonoBehaviour {

	private Animator animator;
	private InputStateWithMove inputState;

	// Use this for initialization
	void Awake () {
	
		animator = GetComponent<Animator> ();
		inputState = GetComponent<InputStateWithMove> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		var running = true;

		if(inputState.absVelX > 0 && inputState.absVelY < inputState.standingThreshold){
			running = false;
			animator.SetBool ("Running", running);
		}

		animator.SetBool ("Running", running);



	}
}
