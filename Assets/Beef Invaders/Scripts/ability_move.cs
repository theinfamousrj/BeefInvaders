using UnityEngine;
using System.Collections;

public class ability_move : MonoBehaviour {
	
	public float speed = 1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("MoveUp")) {
			transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
		}
		if(Input.GetButton("MoveDown")) {
			transform.position += new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);
		}
		if(Input.GetButton("MoveLeft")) {
			transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
		}
		if(Input.GetButton("MoveRight")) {
			transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
		}
	}
}
