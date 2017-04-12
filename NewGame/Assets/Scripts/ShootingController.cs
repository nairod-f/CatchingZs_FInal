using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour {

	// the bullet template - link in Unity
	public GameObject bullet;

	// the spawn point where the bullet will start
	public Transform spawnPoint;

	// is it the player that's shooting, or the enemy?
	public bool autoFire = false;

	// if the object is auto-firing, how often will it do so?
	public float fireInterval = 0f;


	// when the script launches, it will set the autofire
	void Start () {

		if (autoFire) {
			InvokeRepeating ("Shoot", fireInterval, fireInterval);
		}

	}


	// shooting controls should be in the update method
	void Update () {

		// shoot when the player presses space
		if (!autoFire && Input.GetKeyDown (KeyCode.Space)) {
			Shoot ();
		}

	}

	// Create a bullet on the spawn point
	void Shoot () {

		// Create an instance of the template
		// Create the bullet,
		// where the spawn point is,
		// with the character's rotation
		Instantiate (bullet, spawnPoint.position, transform.rotation);

	}

}
