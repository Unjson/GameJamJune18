using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBehaviour : MonoBehaviour {

	public int howManyArrows;
	public int howManyPeeps;

	public GameObject[] Peeps;


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
		BroadcastMessage ("slowNPCs", SendMessageOptions.DontRequireReceiver);

		CheckPositions ();
		UpdateStuff ();

	}

	void UpdateStuff(){

		BroadcastMessage ("UpdateCanvas");

		if (LevelLogic.peepsLeft < 1)
		{
			LevelLogic.peepsLeft = 99;
			LevelLogic.currentLevel++;
			Debug.Log (LevelLogic.currentLevel);

			SceneManager.LoadScene (LevelLogic.currentLevel);

		}

	}


	void CheckPositions ()
	{

		for(int i = 0 ; i < Peeps.Length; i++)
		{

			if (Peeps [i] != null) {

				Vector3 peepPosition = Peeps [i].transform.position;

				for (int j = i + 1; j < Peeps.Length; j++) {
				
					if (Peeps [j] != null) {

						if (peepPosition == Peeps [j].transform.position) {

							Peeps [i].GetComponent<PeopleBehaviour> ().MutuallyAssuredDestruction ();
							Peeps [j].GetComponent<PeopleBehaviour> ().MutuallyAssuredDestruction ();

						}
							
					}
				}

			}
		}


	}
		
}
