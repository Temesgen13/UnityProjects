using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	int key;
	
	// Use this for initialization
	
	
	void Start () {
		myState = States.cell;
		key = 0;
	}
	
	// Update is called once per frame
	void Update () {
		print(myState);
		
		if(myState ==States.cell){
			state_cell ();
		}
		else if (myState == States.sheets_0){
			state_sheets_0();
		}
		else if (myState == States.lock_0){
			state_lock_0();
		}
		else if (myState == States.freedom){
			state_freedom();
		}
	}
	
	void state_cell(){
	
		text.text = "You wake up in a cell and you want to get out. You see a mirror, some dirty sheets, and the lock\nPress S to examine sheets.\nL to go to the lock.";
			
		if(Input.GetKeyDown(KeyCode.S)){
		
			myState = States.sheets_0;
		}
		else if(Input.GetKeyDown(KeyCode.L)) {

			myState = States.lock_0;
		}
	}
	
	void state_sheets_0(){
		
		text.text = "You are looking the the sheets and you find a key. I wonder why there  is a key inside of the cell? Maybe because I don't feel like writing a really long state machine"+
		" for this tutorial :) Press R to return to roaming your cell or Press P to pick it up and go to lock";
		
		if(Input.GetKeyDown(KeyCode.R)){
			
			myState = States.cell;
		}
		else if(Input.GetKeyDown(KeyCode.P)) {
			key = 1;
			myState = States.lock_0;
		}
	}
	
	void state_lock_0(){
		
		if(key == 0){
			text.text = "You look at the lock... and yup, it is locked. I wonder if there is a key around here somewhere. Press R to return";
		}
		else if (key == 1){
			text.text = "You look a the lock... just press O to open it dummy";
		}
		
		
		if(Input.GetKeyDown(KeyCode.R)){
			
			myState = States.cell;
		}
		else if(Input.GetKeyDown(KeyCode.O)) {
			myState = States.freedom;
		}
	}
	
	void state_freedom(){
		
		text.text = "You open the cell and leave the cell... exhilarating. Press R to replay or Q to quit.";
		
		if(Input.GetKeyDown(KeyCode.R)){
			
			myState = States.cell;
		}
		else if(Input.GetKeyDown(KeyCode.Q)) {
			Application.Quit();
		
		
			}
	}		
}
