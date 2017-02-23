using UnityEngine;
using System.Collections;

public class HitZombie : MonoBehaviour {

	private GameObject player;
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("hit zombie");
		if (other.tag.Equals("Player")) {
			Rigidbody2D otherBody = other.GetComponent<Rigidbody2D> ();
			otherBody.velocity = new Vector2 (-400, 200);
		}
	}
}
