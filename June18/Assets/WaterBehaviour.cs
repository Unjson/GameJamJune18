using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBehaviour : MonoBehaviour {

	private Renderer waterTexture;

	private float offsetX;
	private float offsetY;

	// Use this for initialization
	void Start () {

		waterTexture = GetComponent<Renderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		offsetX += Random.Range (0.00001f, 0.0001f); 
		offsetY += Random.Range (-0.0001f, 0.00005f);

		waterTexture.material.mainTextureOffset = new Vector2(offsetX, offsetY);


	}
}
