using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ColliderController : MonoBehaviour {

	// this is the player score
	public int lives = 3;

	// this is the canvas text box
	public Text scoreText;

	// this variable gives us the number of spheres in the scene
	protected int numOfSpheres;

    // this is the player score
    public int score = 0;

    // this is the canvas text box
    public Text pointText;


    // when the script launches, get the number of spheres
    void Start () {

		// this gives us the number of spheres on the scene.
		numOfSpheres = GameObject.FindGameObjectsWithTag ("Sphere").Length;

	}


	// when the capsule hits a sphere with a
	// trigger collider, do something
	void OnTriggerEnter2D (Collider2D c) {

		// check that the player has hit a sphere
		if (c.tag == "Sphere") {
			// increment the score when the capsule
			// hits the sphere
			lives -= 1;

			// adjust the score on the canvas
			scoreText.text = "Rude Awakeining in " + lives;

			// disable the collider so it doesn't repeat
			c.enabled = false;

			// destroy the sphere so we can't hit it
			// a second time
			Destroy (c.gameObject);

			// show us the score in the console
			// Ctrl + Shift + C in Unity
			Debug.Log (lives);

			// check that the score is the same
			// as the number of spheres, and end
			// the game.
			if (lives <= 0) {
                SceneManager.LoadScene ("GameOver Scene");
			}

		}
        else if (c.tag == "Zzz")
        {
            // increment the score when the capsule
            // hits the sphere
            score += 1;

            // adjust the score on the canvas
            pointText.text = "Happy sleep " + score;

            // disable the collider so it doesn't repeat
            c.enabled = false;

            // destroy the sphere so we can't hit it
            // a second time
            Destroy(c.gameObject);

            // show us the score in the console
            // Ctrl + Shift + C in Unity
            Debug.Log(score);

        }

    }

}
