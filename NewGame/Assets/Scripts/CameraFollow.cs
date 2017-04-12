using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform playerObject;
	Vector3 relativePos;
	float lerpSpeed = 10f;

	// Use this for initialization
	void Start () {

		// how far is the camera from the player?
		relativePos = transform.position - playerObject.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// where should the camera be?
		Vector3 targetPos = playerObject.position + relativePos;

		// move the camera with the player
		// Lerp = Linear Interpolation, Smooth in and out
		transform.position = Vector3.Lerp (transform.position, targetPos, Time.deltaTime * lerpSpeed);

	}
}
