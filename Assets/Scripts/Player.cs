using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int starting_health = 100;
	public int current_health;
	public Rigidbody rb;
	public BoxCollider bc;
	public int speed = 50;
	//public Slider health_slider;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		bc = GetComponent<BoxCollider> ();
		current_health = starting_health;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			rb.AddForce(transform.right * speed);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			rb.AddForce(transform.right * -speed);
		}
	}


}
