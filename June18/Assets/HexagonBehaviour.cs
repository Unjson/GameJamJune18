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

	public string inhabitant;

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


		if (destHex.inhabitant == null) {

			destHex.ShootArrow (dir);

		}

		//TODO ArrowHit()
			


	}

}
