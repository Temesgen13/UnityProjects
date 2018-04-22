using UnityEngine;
using System.Collections;

public class Briick : MonoBehaviour {
	private LevelManager levelManager;
	public AudioClip crack;
	public static int breakableCount = 0;
	private bool isBreakable;
	private int timesHit;
	public Sprite [] hitSprites;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		
		if(isBreakable){
		
			breakableCount++;
			//print (breakableCount);
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	
	void OnCollisionEnter2D(Collision2D coll) {		

		if(isBreakable){
			HandleHits();
			

		}

	}
	
	void HandleHits(){
		int maxHits;
		maxHits = hitSprites.Length + 1;
		timesHit++;
		
		if (timesHit >= maxHits){
			//AudioSource.PlayClipAtPoint(crack, transform.position);
			breakableCount--;
			//print (breakableCount);
			Destroy(gameObject);
			levelManager.BrickDestroy();
		}
		else {
			
			LoadSprites();
		}
	}
	void LoadSprites(){

		int spriteIndex = timesHit -1;
		
		if (hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
