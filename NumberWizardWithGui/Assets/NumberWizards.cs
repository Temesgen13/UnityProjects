using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuesses = 10;
	public Text guessText;
	void Start(){
	
		StartGame ();
	}

	
	
	public void GuessHigher(){
		min = guess;
		updateGuess();	
		
	}
	
	public void GuessLower(){
		max = guess;
		updateGuess();	
		
	}

	
	void updateGuess(){
		guess = (max + min)/2;
		guessText.text = guess.ToString();
		maxGuesses--;
		
		if (maxGuesses == 0){
		
			Application.LoadLevel("Win");
		}
	//	print ("Higher or lower than " +  guess);	
//		print("Up arrow for higher, down for lower, return for equal");		
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
