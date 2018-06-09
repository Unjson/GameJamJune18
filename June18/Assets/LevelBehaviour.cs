using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBehaviour : MonoBehaviour {

	public int howManyArrows;
	public int howManyPeeps;


	// Use this for initialization
	void Start () {

		LevelLogic.arrowCount = howManyArrows;
		LevelLogic.peepsLeft = howManyPeeps;
		BroadcastMessage ("UpdateCanvas");

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("restart"))
			{
			SceneManager.LoadScene (LevelLogic.currentLevel);
			}
	}

	void PlayerMoved(){

		BroadcastMessage ("moveNPCs");

		BroadcastMessage ("UpdateCanvas");

	}

	void UpdateStuff(){

		BroadcastMessage ("UpdateCanvas");

		if (LevelLogic.peepsLeft < 1)
		{

			LevelLogic.currentLevel++;

			SceneManager.LoadScene (LevelLogic.currentLevel);

		}

	}
		
}
