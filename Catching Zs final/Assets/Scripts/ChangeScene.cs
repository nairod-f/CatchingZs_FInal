using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {


	public float delay = 6;


	void Start()
	{
		StartCoroutine(LoadLevelAfterDelay(delay));     
	}

	IEnumerator LoadLevelAfterDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene("YouWin Scene");
	}
}