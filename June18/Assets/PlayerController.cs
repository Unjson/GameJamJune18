using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject positon;

	private HexagonBehaviour homeHex;
	private HexagonBehaviour destHex;

	// Use this for initialization
	void Start () {
		
 		homeHex = positon.gameObject.GetComponent<HexagonBehaviour>();
	}
	
	// Update is called once per frame
	void Update () {

		//INPUT MANAGER

		if(Input.GetButtonDown("UpLeft")){

			destHex = homeHex.aboveLeft.GetComponent<HexagonBehaviour>();

			if (destHex.inhabitant == null) {

				//Set new Home
				this.transform.position = homeHex.aboveLeft.transform.position;
				homeHex = destHex;
				positon = destHex.gameObject;

			}

		}

		if(Input.GetButtonDown("UpRight")){

			destHex = homeHex.aboveRight.GetComponent<HexagonBehaviour>();

			if (destHex.inhabitant == null) {

				//Set new Home
				this.transform.position = homeHex.aboveRight.transform.position;
				homeHex = destHex;
				positon = destHex.gameObject;

			}
		}

		if(Input.GetButtonDown("Left")){

			destHex = homeHex.left.GetComponent<HexagonBehaviour>();

			if (destHex.inhabitant == null) {

				//Set new Home
				this.transform.position = homeHex.left.transform.position;
				homeHex = destHex;
				positon = destHex.gameObject;

			}
		}

		if(Input.GetButtonDown("Right")){

			destHex = homeHex.right.GetComponent<HexagonBehaviour>();

			if (destHex.inhabitant == null) {

				//Set new Home
				this.transform.position = homeHex.right.transform.position;
				homeHex = destHex;
				positon = destHex.gameObject;

			}
		}

		if(Input.GetButtonDown("DownLeft")){

			destHex = homeHex.belowLeft.GetComponent<HexagonBehaviour>();

			if (destHex.inhabitant == null) {

				//Set new Home
				this.transform.position = homeHex.belowLeft.transform.position;
				homeHex = destHex;
				positon = destHex.gameObject;

			}
		}

		if(Input.GetButtonDown("DownRight")){

			destHex = homeHex.belowRight.GetComponent<HexagonBehaviour>();

			if (destHex.inhabitant == null) {

				//Set new Home
				this.transform.position = homeHex.belowRight.transform.position;
				homeHex = destHex;
				positon = destHex.gameObject;

			}
		}
				

	}
}
