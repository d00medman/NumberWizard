using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number wizard");
		print ("Pick a number, but don't tell me!");

		int max = 1000;
		int min = 1;

		print ("Pick a number between " + min + " and " + max);
		print ("Is the number higher or lower than 500?");
		print ("Up Arrow for higher, down arrow for lower, equals for equals");


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up Arrow Clicked");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down Arrow Clicked");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("You win");
		}
	}
}
