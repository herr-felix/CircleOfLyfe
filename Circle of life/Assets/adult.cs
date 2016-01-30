using UnityEngine;
using System.Collections;

public class adult : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
		//transform.Translate (new Vector3 (horizontal, 0, 0));
		gameObject.transform.position = new Vector3 (transform.position.x + horizontal, transform.position.y, transform.position.z);
		transform.RotateAround (new Vector2(transform.position.x + (float)((int)horizontal%15), 0), new Vector3 (0, 0, 1.0f), horizontal * -10);
		//gameObject.transform.position = new Vector3 (transform.position.x + horizontal, transform.position.y, transform.position.z);

	}
}
