using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	

	
	
	public void LoadLevel(string name){
	
		Debug.Log("Level loaded " + name); 
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		
		Debug.Log("Quitting...");
		Application.Quit();
	}
}
