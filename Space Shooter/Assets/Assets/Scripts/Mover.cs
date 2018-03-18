using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	// Use this for initialization
	public Rigidbody rigb;
	public float speed;


	void Start(){
		rigb = GetComponent<Rigidbody> ();
		rigb.velocity = transform.forward*speed;
	}
	

}
