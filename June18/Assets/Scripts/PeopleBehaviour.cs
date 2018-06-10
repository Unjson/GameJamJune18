using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleBehaviour : MonoBehaviour {


	public string characterName;
	public bool isMoving;
	public string direction;

	private bool isSlowed;

	public GameObject positon;

	private HexagonBehaviour homeHex;
	private HexagonBehaviour destHex;


	// Use this for initialization
	void Start () {

		isSlowed = false;

		homeHex = positon.gameObject.GetComponent<HexagonBehaviour>();
		homeHex.inhabitant = this.gameObject;
		homeHex.inhabitantType = 2;

	}
	
	// Update is called once per frame
	void Update () {


	}


	void moveNPCs(){

		if (isMoving && !isSlowed) {

			if (direction == "UpLeft") {


				destHex = homeHex.aboveLeft.GetComponent<HexagonBehaviour> ();
		

				if (destHex.inhabitantType == 0 || destHex.inhabitantType == 2) {

					//Set new Home
					this.transform.position = homeHex.aboveLeft.transform.position;
				

				}

			}

			if (direction == "UpRight") {

				destHex = homeHex.aboveRight.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitantType == 0 || destHex.inhabitantType == 2) {

					//Set new Home
					this.transform.position = homeHex.aboveRight.transform.position;

				}
			}

			if (direction == "Left") {

				destHex = homeHex.left.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitantType == 0 || destHex.inhabitantType == 2) {

					//Set new Home
					this.transform.position = homeHex.left.transform.position;

				}
			}

			if (direction == "Right") {

				destHex = homeHex.right.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitantType == 0 || destHex.inhabitantType == 2) {

					//Set new Home
					this.transform.position = homeHex.right.transform.position;

				}
			}

			if (direction == "DownLeft") {

				destHex = homeHex.belowLeft.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitantType == 0 || destHex.inhabitantType == 2) {

					//Set new Home
					this.transform.position = homeHex.belowLeft.transform.position;

				}
			}

			if (direction == "DownRight") {

				destHex = homeHex.belowRight.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitantType == 0 || destHex.inhabitantType == 2) {

					//Set new Home
					this.transform.position = homeHex.belowRight.transform.position;

				}
			}

			homeHex.inhabitant = null;
			homeHex.inhabitantType = 0;

			/*if (destHex.inhabitantType == 2) 
			{

				PeopleBehaviour significantOther = destHex.inhabitant.GetComponent<PeopleBehaviour> ();

				significantOther.MutuallyAssuredDestruction ();
				this.MutuallyAssuredDestruction ();

			}*/


			homeHex = destHex;
			if (homeHex.gameObject.name == "Deadzone")
			{
				Debug.Log("Omae Wa Shindeiru");
				Destroy(this.gameObject);

			}

			homeHex.inhabitant = this.gameObject;
			homeHex.inhabitantType = 2;
			positon = destHex.gameObject;
		} 


		else if (isSlowed) {
		
			isSlowed = false;

		}


	}
		

	public void MutuallyAssuredDestruction (){

		Destroy (this.gameObject);
		LevelLogic.peepsLeft--;
		SendMessageUpwards ("UpdateStuff");

	}


	public void slowDown (){

		if (!isSlowed){

			isSlowed = true;
		}

	}


}
