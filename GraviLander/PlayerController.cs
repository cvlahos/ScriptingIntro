using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	//Make a reference to the Rigidbody class in the unity API
	public Rigidbody2D playerRB;
	
	//Create a public variable to control the thrusterForce
	public float thrusterForce;
	
	//create a public variable to control the turnSpeed
	public float turnSpeed;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space)) 
		{
			//player RB  AddRelativeForce
			playerRB.AddRelativeForce(new Vector2(0,thrusterForce));
			
		}
		
		
		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			
			//rotate the luner cube Right
			transform.Rotate(0,0,-turnSpeed);
			
			
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			
			//rotate the luner cube Left
			transform.Rotate(0,0,turnSpeed);

			
		}
		
	}
	
	
}
