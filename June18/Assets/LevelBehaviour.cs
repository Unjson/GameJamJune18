using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour {


	public int arrowCount;
	public int peepsLeft;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	}

	void PlayerMoved(){

		BroadcastMessage ("moveNPCs");

	}
		
}
