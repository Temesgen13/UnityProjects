using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frames
	void Update () {
		
		
		if(Input.GetMouseButtonDown(0)){

			
			this.rigidbody2D.velocity = new Vector2(2f, 30f);	
			hasStarted = true;
			
			

		
		}
		paddle.transform.position = new Vector2(this.transform.position.x, 1);
		if(!hasStarted){
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}
	}
	void OnCollisionEnter2D(Collision2D collision ){
		if(hasStarted){
			Vector2 tweak = new Vector2(Random.Range(0f, 0.2f),Random.Range(0f, 0.2f));
			this.rigidbody2D.velocity += tweak;
			print (tweak);
		}
	}
} 
