using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleBehaviour : MonoBehaviour {


	public string CharacterName;
	public bool isMoving;
	public string direction;

	private bool isSlowed;

	public GameObject positon;

	private HexagonBehaviour homeHex;
	private HexagonBehaviour destHex;

	// Use this for initialization
	void Start () {

		homeHex = positon.gameObject.GetComponent<HexagonBehaviour>();

	}
	
	// Update is called once per frame
	void Update () {


	}


	void moveNPCs(){

		if (isMoving && !isSlowed) {

			if (direction == "UpLeft") {

				destHex = homeHex.aboveLeft.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitant == null) {

					//Set new Home
					this.transform.position = homeHex.aboveLeft.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.CharacterName;
					positon = destHex.gameObject;

				}

			}

			if (direction == "UpRight") {

				destHex = homeHex.aboveRight.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitant == null) {

					//Set new Home
					this.transform.position = homeHex.aboveRight.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.CharacterName;
					positon = destHex.gameObject;

				}
			}

			if (direction == "Left") {

				destHex = homeHex.left.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitant == null) {

					//Set new Home
					this.transform.position = homeHex.left.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.CharacterName;
					positon = destHex.gameObject;

				}
			}

			if (direction == "Right") {

				destHex = homeHex.right.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitant == null) {

					//Set new Home
					this.transform.position = homeHex.right.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.CharacterName;
					positon = destHex.gameObject;

				}
			}

			if (direction == "DownLeft") {

				destHex = homeHex.belowLeft.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitant == null) {

					//Set new Home
					this.transform.position = homeHex.belowLeft.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.CharacterName;
					positon = destHex.gameObject;

				}
			}

			if (direction == "DownRight") {

				destHex = homeHex.belowRight.GetComponent<HexagonBehaviour> ();

				if (destHex.inhabitant == null) {

					//Set new Home
					this.transform.position = homeHex.belowRight.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.CharacterName;
					positon = destHex.gameObject;

				}
			}
		} 


		else if (isSlowed) {
		
			isSlowed = false;

		}


	}

}
