using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehaviour : MonoBehaviour {

	public Image arrowA;
	public Image arrowB;
	public Image arrowC;
	public Image arrowD;


	public Text peepsText;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {



	}


	void UpdateCanvas(){

		peepsText.text = "Peeps Left   " + LevelLogic.peepsLeft;



		if (LevelLogic.arrowCount > 0) 
		{

			arrowA.enabled = true;

		}else
		{
			arrowA.enabled = false;
		}

		if (LevelLogic.arrowCount > 1) 
		{

			arrowB.enabled = true;

		}else
		{
			arrowB.enabled = false;
		}

		if (LevelLogic.arrowCount > 2) 
		{

			arrowC.enabled = true;

		}else
		{
			arrowC.enabled = false;
		}

		if (LevelLogic.arrowCount > 3) 
		{

			arrowD.enabled = true;

		}else
		{
			arrowD.enabled = false;
		}


	}

}
