using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public Rigidbody rigb;
	public float tumble;


	void Start(){
		rigb = GetComponent<Rigidbody> ();
		rigb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
