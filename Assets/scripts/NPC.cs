using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
	private short Health = 100;//NPC Health. the value is between 0-100.
	private short Strength = 100; // NPC Strength, again between 0-100.
	private string Name = "Hadi";// Name of NPC character
	// Use this for initialization
	void Start () {
		
		Debug.Log("My name is " + Name); // This is how we add two strings to each other.
		//Another way to do this is as follows which is more readable:
		// string myMessage = "My name is" + Name;
		// Debug.log(myMessage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
