using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire"))
			{
				StartFirstLevel();
			}
		
	}

	public void StartFirstLevel()
	{

		LevelLogic.currentLevel++;

		SceneManager.LoadScene (LevelLogic.currentLevel);

	}

	public void quitGame()
	{
		Application.Quit ();
	}
}
