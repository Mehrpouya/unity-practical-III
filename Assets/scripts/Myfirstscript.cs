/* Your comments */
using System.Collections; // This library is usefull for writing to console.
using System.Collections.Generic;
using UnityEngine;

/* 
	Same comment!
	Developed by: Hadi Mehrpouya
	Date: 13/09/2017
	Modified: 19/09/2017

 */
// Same comment!
// Developed by: Hadi Mehrpouya
// Date 19/09/2017
//Modified: 19/09/2017

/* 
		VARIABLE	Default value
		bool 		False
		byte 		0
		char 		'\0'
		decimal 	0.0M
		double 		0.0D
		float 		0.0F
		int 		0
		long 		0L
		sbyte 		0
		short 		0
		uint 		0
		ulong 		0
		ushort 		0
*/
public class Myfirstscript : MonoBehaviour {
	int outsideTemprature = 16;
	int myRoomTemprature= 21;
	bool isCold = false; //boolean variable that can either be true or false.
	int tempratureDiff;
	// Use this for initialization
	void Start () {
        //Debug.log("hello");
        Debug.Log("Hello Hadi" + tempratureDiff);
		tempratureDiff = myRoomTemprature - outsideTemprature;
		if(tempratureDiff>7)
			Debug.Log("you will need a jacket!");
		else
			Debug.Log("you won't need a jacket!");
    }

	
	
	// Update is called once per frame
	void Update () {
		
	}
}
