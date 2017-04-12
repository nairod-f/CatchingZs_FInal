using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	// a reference to the player object
	protected Transform playerObject;

	// a reference to the shooting script
	protected ShootingController shooting;

	// has the enemy seen the player?
	protected bool playerSeen = false;


	// When the script wakes up, find its components
	void Awake () {

		// get the shooting controller on this object
		shooting = GetComponent <ShootingController> ();

	}

	// When the script launches, find the player
	void Start () {

		// disable the shooting script until we need it
		shooting.enabled = false;

		// get the transform control of the player
		playerObject = GameObject.FindGameObjectWithTag ("Player").transform;
		
	}
	
	// Rotate the enemy towards the player at all times
	void Update () {

		if (playerSeen) {

			// this tells the enemy to always look at the player
			transform.LookAt (playerObject.position);

		} else {

			Ray ray = new Ray (transform.position, transform.TransformDirection (Vector3.forward));
			RaycastHit hit;

			// cast a ray, and output the result to hit
			if (Physics.Raycast (ray, out hit, 50f)) {

				if (hit.transform.tag == "Player") {

					playerSeen = true;
					shooting.enabled = true;

				}

			}

		}
	}
}
