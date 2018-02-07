using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHandler : MonoBehaviour {

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	public GameObject other;
	//Use raycasts to see what the pointer is hovering over in the GUI
	Ray ray;
	RaycastHit hit;

	//use to select which tag will cause a mouse cursor change
	private string target_name = "Target";

	void Start () {
		
	}

	//using a chain of else-ifs or a switch statement, multiple character types
	//can be handled here, for instance, if hovering over a friendly npc,
	//the mouse cursor could display a talk bubble, assuming they have a collider attached
	//otherwise, refactoring will be necessary
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit))
		{
			//Debug.Log (hit.collider.name);
			if(hit.collider.gameObject.tag == target_name)
			{ Cursor.SetCursor(cursorTexture, hotSpot, cursorMode); }
		}
	}
}
