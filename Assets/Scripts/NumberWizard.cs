using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;


	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame (){
		max = 1000;
		min = 1;
		guess = 500;


		print ("--------------------");
		print ("Welcome to Number wizard");
		print ("Pick a number, but don't tell me!");
		print ("Pick a number between " + min + " and " + max);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up Arrow for higher, down arrow for lower, return for equals");

		max += 1;
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// print ("Up Arrow Clicked");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			// print ("Down Arrow Clicked");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("You win");
			StartGame();
		}
	}

	void NextGuess (){
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up Arrow for higher, down arrow for lower, return for equals");
	}
}
