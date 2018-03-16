using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
	private int count;
	public Text countText;
	public Text winText;

    private void Start()
    {
		count = 0;
		SetCountText ();
        rb = GetComponent<Rigidbody>();
		winText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Pick Up")){
			count = count + 1;
			other.gameObject.SetActive (false);
			SetCountText ();
		}
	} 

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();

		if (count >= 12) {
			winText.text = "You Win!";
		}

	}

}
