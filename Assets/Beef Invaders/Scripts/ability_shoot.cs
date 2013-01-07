using UnityEngine;
using System.Collections;

public class ability_shoot : MonoBehaviour {
	
	public GameObject[] bulletPrefab;
	public int bulletType = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Shoot")) {
			Vector3 newPosition = new Vector3(transform.position.x + 0.8f, transform.position.y, transform.position.z);
			GameObject bulletInstance = (GameObject) Instantiate(this.bulletPrefab[0], newPosition, Quaternion.identity);
			bulletInstance.rigidbody.AddForce(1.0f * Time.deltaTime, 0.0f, 0.0f);
		}
	}
}
