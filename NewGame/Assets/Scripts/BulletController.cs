using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour {

	// the bullet speed
	protected float speed = 50f;

	// the bullet's life span
	protected float lifeSpan = 3f;

	// a reference to the bullet's physics component
	protected Rigidbody _rigidbody;


	// when the script wakes up
	void Awake () {

		_rigidbody = GetComponent <Rigidbody> ();

	}


	// when the script launches, push the bullet
	void Start () {

		// find where I'm looking from the world's perspective
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		// push the bullet forward depending on where I'm looking
		_rigidbody.AddForce (fwd * speed, ForceMode.Impulse);

	}


	// move the bullet on every frame
	void Update () {

		// Time.deltaTime = time passed between frames
		lifeSpan -= Time.deltaTime;
		if (lifeSpan <= 0f) {
			Destroy (gameObject);
		}

	}

	// when the bullet collides with anything, it is removed from play
	void OnCollisionEnter (Collision c) {

		// if the enemy is hit, kill them
		if (c.gameObject.tag == "Enemy") {
			Destroy (c.gameObject);
		}

		// if the player is hit, game over
		if (c.gameObject.tag == "Player") {
			SceneManager.LoadScene ("GameOver Scene");
		}

		Destroy (gameObject);

	}

}
