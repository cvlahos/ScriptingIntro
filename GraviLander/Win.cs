using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Win : MonoBehaviour 
{
	public Text winText;			//Store a reference to the UI Text component which will display the 'You win' message

	// Use this for initialization
	void Start () {

		//Initialze winText to a blank string since we haven't won yet at beginning.
		winText.text = "";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D()
	{
		winText.text = "You Win";
	}
}