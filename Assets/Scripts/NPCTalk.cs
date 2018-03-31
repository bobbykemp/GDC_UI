using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCTalk : MonoBehaviour {

	public Text text;

	void Start(){
		text.enabled = false;
	}

	void OnMouseDown(){
		if (text.enabled) { //if paused unpause
			text.enabled = false;
		} else {
			text.enabled = true;
		}
	}
}
