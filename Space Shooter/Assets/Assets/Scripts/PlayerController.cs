using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[System.Serializable]
public class Boundary{
	public float xMin, xMax, zMin, zMax;
	
}
public class PlayerController : MonoBehaviour {

	public Rigidbody rigb;
	public float speed;
	public Boundary boundary;
	public float tilt;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private AudioSource shotsFired;
	private float nextFire;

	void Start(){
		rigb = GetComponent<Rigidbody> ();
		shotsFired = GetComponent<AudioSource> ();
	}
	void FixedUpdate(){
		float moveHorizonatal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizonatal, 0.0f, moveVertical);
		rigb.velocity = movement*speed;

		rigb.position = new Vector3 (
			Mathf.Clamp(rigb.position.x, boundary.xMin, boundary.xMax),
			0,
			Mathf.Clamp(rigb.position.z, boundary.zMin, boundary.zMax));

		rigb.rotation = Quaternion.Euler (0.0f, 0.0f, rigb.velocity.x * -tilt);
			
		}
	void Update(){

		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			shotsFired.Play ();
			
			nextFire = Time.time + fireRate;
			Instantiate(shot,shotSpawn.position, shotSpawn.rotation);

		}
	}

}
