using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumpfBehaviour : HexagonBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void slowNPCs(){

	if (inhabitantType == 2){

			inhabitant.GetComponent<PeopleBehaviour> ().slowDown ();
			inhabitantType = 3;

	}
	}

}
