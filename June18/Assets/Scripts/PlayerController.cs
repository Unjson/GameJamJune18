using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject positon;

	//private string characterName;

	private HexagonBehaviour homeHex;
	private HexagonBehaviour destHex;

	private bool isShooting;

	private ParticleSystem shootingEffect;

	// Use this for initialization
	void Start () {

		isShooting = false;
		//characterName = "Amor";
 		homeHex = positon.gameObject.GetComponent<HexagonBehaviour>();
		homeHex.inhabitant = this.gameObject;
		shootingEffect = this.GetComponent<ParticleSystem> ();
		shootingEffect.Stop();

	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetButtonDown("Fire") && LevelLogic.arrowCount > 0)
		{
			isShooting = !isShooting;
			updateParticles ();

		}



		//INPUT MANAGER
		if (isShooting == false) {
			
			if (Input.GetButtonDown ("UpLeft")) {

				destHex = homeHex.aboveLeft.GetComponent<HexagonBehaviour> ();

				if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

					//Set new Home
					this.transform.position = homeHex.aboveLeft.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.gameObject;
					positon = destHex.gameObject;


					this.transform.eulerAngles = new Vector3 (0, 120, 0);

					SendMessageUpwards ("PlayerMoved");

				}

			}

			if (Input.GetButtonDown ("UpRight")) {

				destHex = homeHex.aboveRight.GetComponent<HexagonBehaviour> ();

				if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

					//Set new Home
					this.transform.position = homeHex.aboveRight.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.gameObject;
					positon = destHex.gameObject;

					this.transform.eulerAngles = new Vector3 (0, -120, 0);

					SendMessageUpwards ("PlayerMoved");

				}
			}

			if (Input.GetButtonDown ("Left")) {

				destHex = homeHex.left.GetComponent<HexagonBehaviour> ();

				if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

					//Set new Home
					this.transform.position = homeHex.left.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.gameObject;
					positon = destHex.gameObject;

					this.transform.eulerAngles = new Vector3 (0, 90, 0);

					SendMessageUpwards ("PlayerMoved");

				}
			}

			if (Input.GetButtonDown ("Right")) {

				destHex = homeHex.right.GetComponent<HexagonBehaviour> ();

				if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

					//Set new Home
					this.transform.position = homeHex.right.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.gameObject;
					positon = destHex.gameObject;

					this.transform.eulerAngles = new Vector3 (0, -90, 0);

					SendMessageUpwards ("PlayerMoved");

				}
			}

			if (Input.GetButtonDown ("DownLeft")) {

				destHex = homeHex.belowLeft.GetComponent<HexagonBehaviour> ();

				if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

					//Set new Home
					this.transform.position = homeHex.belowLeft.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.gameObject;
					positon = destHex.gameObject;

					this.transform.eulerAngles = new Vector3 (0, 30, 0);

					SendMessageUpwards ("PlayerMoved");

				}
			}

			if (Input.GetButtonDown ("DownRight")) {

				destHex = homeHex.belowRight.GetComponent<HexagonBehaviour> ();

				if ((destHex.inhabitant == null) && (destHex.gameObject.name != "Deadzone")) {

					//Set new Home
					this.transform.position = homeHex.belowRight.transform.position;

					homeHex.inhabitant = null;
					homeHex = destHex;
					homeHex.inhabitant = this.gameObject;
					positon = destHex.gameObject;

					this.transform.eulerAngles = new Vector3 (0, -30, 0);

					SendMessageUpwards ("PlayerMoved");

				}
			}
		}



		if (isShooting == true)
		{

			if (Input.anyKeyDown && LevelLogic.arrowCount > 0) {

				string dir = null;
				destHex = homeHex.GetComponent<HexagonBehaviour> ();

				if (Input.GetButtonDown ("UpLeft")) {
					
					dir = "UpLeft";
					LevelLogic.arrowCount--;
					isShooting = false;
				}

				if (Input.GetButtonDown ("UpRight")) {

					dir = "UpRight";
					LevelLogic.arrowCount--;
					isShooting = false;

				}

				if (Input.GetButtonDown ("Left")) {

					dir = "Left";
					LevelLogic.arrowCount--;
					isShooting = false;

				}

				if (Input.GetButtonDown ("Right")) {

					dir = "Right";
					LevelLogic.arrowCount--;
					isShooting = false;

				}

				if (Input.GetButtonDown ("DownLeft")) {

					dir = "DownLeft";
					LevelLogic.arrowCount--;
					isShooting = false;

				}

				if (Input.GetButtonDown ("DownRight")) {

					dir = "DownRight";
					LevelLogic.arrowCount--;
					isShooting = false;
				}
					

				destHex.SendMessage ("ShootArrow", dir);
				SendMessageUpwards ("UpdateStuff");

				updateParticles ();

			}

		}
			

	}

	void updateParticles()
	{
		Debug.Log (isShooting);

		if (isShooting) {
			shootingEffect.Play ();
		} else {
			shootingEffect.Stop ();
		}

	}



}
