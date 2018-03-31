using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHandler : MonoBehaviour {

	public Texture2D enemy;
	public Texture2D talkable;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	public GameObject other;
	public GameObject player;
	public bool can_melee;
	public float max_melee_range = .6f;
	public Enemy opponent;
	//Use raycasts to see what the pointer is hovering over in the GUI
	Ray ray;
	RaycastHit hit;
	float dist;

	//use to select which tag will cause a mouse cursor change
	private string target_name = "Target";

	void Start () {
		opponent = GameObject.FindGameObjectWithTag (target_name).GetComponent<Enemy> ();
		opponent.SetCountText ();
	}

	//using a chain of else-ifs or a switch statement, multiple character types
	//can be handled here, for instance, if hovering over a friendly npc,
	//the mouse cursor could display a talk bubble, assuming they have a collider attached
	//otherwise, refactoring will be necessary
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Cursor.SetCursor (null, hotSpot, cursorMode); 
		if(Physics.Raycast(ray, out hit))
		{
			switch(hit.collider.gameObject.tag){
			case("Target"):
				Cursor.SetCursor (enemy, hotSpot, cursorMode);
				if (Input.GetMouseButtonDown (0)) {
					Melee ();
				}
				break;
			case("Background"):
				//Debug.Log(ray.origin);
				break;
			case("talkable_npc"):
				Cursor.SetCursor (talkable, hotSpot, cursorMode);
				break;
			};
				
		}
		dist = Vector3.Distance (ray.origin, player.transform.position);
		dist = dist - 9.7f;
		//Debug.Log(dist);
		if (dist > max_melee_range)
			can_melee = false;
		else {
			can_melee = true;
		}
	}

	void Melee(){
		//if (can_melee) {
			opponent.Damage (1);
		//}
	}
}
