using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D() // Collision message 
		
	{
		Application.LoadLevel (Application.loadedLevel); // this will reset the current level
		
	}


}
