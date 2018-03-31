using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public int starting_health = 100;
	public int current_health;
	public bool damaged;
	public Text count;

	// Use this for initialization
	void Start () {
		current_health = starting_health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(int amount){
		current_health -= amount;
		//health_slider.value = current_health;
	}

	public void SetCountText(){
		count.text = "Health: " + current_health.ToString ();
	}
}
