using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chocolateFactory : MonoBehaviour {
	int milkSupply = 1000; //This is in litres
	int butterSupply = 100; // In kilos
	int waterSupply = 1000; //Litres
	int cocoaSupply = 1000; //Kilos
	bool isWaterBoiled = false;
	bool isButterMixed = false;
	bool isCocoaMixed = false;
	bool isChocolateReady = false;
	// Use this for initialization
	void Start () {
		Debug.Log("Boiling water");
		isWaterBoiled=true;
		if (isWaterBoiled) {
			Debug.Log("turn off the gas");
			Debug.Log("mixing butter");
			isButterMixed=true;
		}
		if(isButterMixed){
			Debug.Log("Mixing cocoa");
			isCocoaMixed=true;
		}
		if(isCocoaMixed){
			Debug.Log("turn the cooler on");
			isChocolateReady=true;
		}
		if(isChocolateReady)
			Debug.Log("Bon Appétit");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
