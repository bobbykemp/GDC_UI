using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour {

	public Canvas canvas;
	private Button button;

	void Start () {
		//UI = GetComponentInChildren<Canvas> ();
		button = GetComponentInChildren<Button>();
		button.onClick.AddListener(ContinueClicked);
		canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			//Debug.Log ("esc pressed");
			PauseGame ();
		}
	}

	void PauseGame (){
		if (canvas.enabled) { //if paused unpause
			canvas.enabled = false;
			Time.timeScale = 1.0f;
		} else {
			canvas.enabled = true;
			Time.timeScale = 0f;
		}
	}

	void ContinueClicked(){
		//Debug.Log ("button clicked");
		PauseGame();
	}
}
