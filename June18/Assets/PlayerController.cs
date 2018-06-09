using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject positon;

	private string characterName;

	private HexagonBehaviour homeHex;
	private HexagonBehaviour destHex;

	// Use this for initialization
	void Start () {

		characterName = "Amor";
 		homeHex = positon.gameObject.GetComponent<HexagonBehaviour>();
		homeHex.inhabitant = characterName;
	}
	
	// Update is called once per frame
	void Update () {

		//INPUT MANAGER

		if(Input.GetButtonDown("UpLeft")){

			destHex = homeHex.aboveLeft.GetComponent<HexagonBehaviour>();

			if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

				//Set new Home
				this.transform.position = homeHex.aboveLeft.transform.position;

				homeHex.inhabitant = null;
				homeHex = destHex;
				homeHex.inhabitant = this.characterName;
				positon = destHex.gameObject;


				this.transform.eulerAngles = new Vector3(0, 120, 0);

			}

		}

		if(Input.GetButtonDown("UpRight")){

			destHex = homeHex.aboveRight.GetComponent<HexagonBehaviour>();

			if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

				//Set new Home
				this.transform.position = homeHex.aboveRight.transform.position;

				homeHex.inhabitant = null;
				homeHex = destHex;
				homeHex.inhabitant = this.characterName;
				positon = destHex.gameObject;

				this.transform.eulerAngles = new Vector3(0, -120, 0);

			}
		}

		if(Input.GetButtonDown("Left")){

			destHex = homeHex.left.GetComponent<HexagonBehaviour>();

			if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

				//Set new Home
				this.transform.position = homeHex.left.transform.position;

				homeHex.inhabitant = null;
				homeHex = destHex;
				homeHex.inhabitant = this.characterName;
				positon = destHex.gameObject;

				this.transform.eulerAngles = new Vector3(0, 90, 0);

			}
		}

		if(Input.GetButtonDown("Right")){

			destHex = homeHex.right.GetComponent<HexagonBehaviour>();

			if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

				//Set new Home
				this.transform.position = homeHex.right.transform.position;

				homeHex.inhabitant = null;
				homeHex = destHex;
				homeHex.inhabitant = this.characterName;
				positon = destHex.gameObject;

				this.transform.eulerAngles = new Vector3(0, -90, 0);

			}
		}

		if(Input.GetButtonDown("DownLeft")){

			destHex = homeHex.belowLeft.GetComponent<HexagonBehaviour>();

			if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

				//Set new Home
				this.transform.position = homeHex.belowLeft.transform.position;

				homeHex.inhabitant = null;
				homeHex = destHex;
				homeHex.inhabitant = this.characterName;
				positon = destHex.gameObject;

				this.transform.eulerAngles = new Vector3(0, 30, 0);

			}
		}

		if(Input.GetButtonDown("DownRight")){

			destHex = homeHex.belowRight.GetComponent<HexagonBehaviour>();

			if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

				//Set new Home
				this.transform.position = homeHex.belowRight.transform.position;

				homeHex.inhabitant = null;
				homeHex = destHex;
				homeHex.inhabitant = this.characterName;
				positon = destHex.gameObject;

				this.transform.eulerAngles = new Vector3(0, -30, 0);

			}
		}
				

	}
}
