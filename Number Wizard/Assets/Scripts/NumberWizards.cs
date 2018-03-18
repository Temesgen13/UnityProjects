using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start(){
	
		StartGame ();
	}

	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			updateGuess();	
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;	
			updateGuess();
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print ("I won!");	
			StartGame ();	
		}	
	}
	
	void updateGuess(){
		guess = (max + min)/2;
		print ("Higher or lower than " +  guess);	
		print("Up arrow for higher, down for lower, return for equal");		
	}
	
	void StartGame () {
		max = 1001;
		min  = 1;
		guess = 500;
		print ("==================================================== \nWelcome to Number Wizard");
		print ("Pick a number in your head... but don't tell me!");	
		print ("The highest number you can pick is 1000");
		print ("The lowest number you can pick is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		print("Up arrow for higher, down for lower, return for equal");		
	}
}
