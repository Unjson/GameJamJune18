using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonBehaviour : MonoBehaviour {


    public GameObject aboveLeft;
	public GameObject aboveRight;
	public GameObject left;
	public GameObject right;
	public GameObject belowLeft;
	public GameObject belowRight;

	public GameObject inhabitant;
	public int inhabitantType = 0;
			/*INHABITANTS:
			 * 
			 * 0 is uninhabited
			 * 1 is player Character
			 * 2 is NPC
			 * 
			*/

	HexagonBehaviour destHex;

    // Use this for initialization
    void Start () {


	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void ShootArrow(string dir){
			
	

	switch(dir)
		{

	case "UpLeft":	
		destHex = aboveLeft.GetComponent<HexagonBehaviour>();
		break;

	case "UpRight":	
		destHex = aboveRight.GetComponent<HexagonBehaviour>();
		break;

	case "Left":	
		destHex = left.GetComponent<HexagonBehaviour>();
		break;

	case "Right":	
		destHex = right.GetComponent<HexagonBehaviour>();
		break;

	case "DownLeft":	
		destHex = belowLeft.GetComponent<HexagonBehaviour>();
		break;

	case "DownRight":	
		destHex = belowRight.GetComponent<HexagonBehaviour>();
		break;

		}


		if (destHex.inhabitant == null && destHex.gameObject.name != "Deadzone") {

			destHex.ShootArrow (dir);

		} else if (destHex.inhabitant != null) 
		{

			PeopleBehaviour target = destHex.inhabitant.GetComponent<PeopleBehaviour> ();
			target.isMoving = true;

			switch (dir) {

			case "UpLeft":	
				
				destHex.inhabitant.transform.eulerAngles = new Vector3 (0, -30, 0);
				target.direction = "DownRight";
				break;

			case "UpRight":	
				
				destHex.inhabitant.transform.eulerAngles = new Vector3 (0, 30, 0);
				target.direction = "DownLeft";
				break;

			case "Left":	

				destHex.inhabitant.transform.eulerAngles = new Vector3 (0, -90, 0);
				target.direction = "Right";
				break;

			case "Right":	

				destHex.inhabitant.transform.eulerAngles = new Vector3 (0, 90, 0);
				target.direction = "Left";
				break;

			case "DownLeft":	

				destHex.inhabitant.transform.eulerAngles = new Vector3 (0,-120, 0);
				target.direction = "UpRight";
				break;

			case "DownRight":	

				destHex.inhabitant.transform.eulerAngles = new Vector3 (0, 120, 0);
				target.direction = "UpLeft";
				break;


			}

		}

		//TODO ArrowHit()
			


	}

}
