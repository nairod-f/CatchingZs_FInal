using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("InGameMenu", LoadSceneMode.Additive);
	}

}
