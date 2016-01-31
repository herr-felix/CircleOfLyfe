using UnityEngine;
using System.Collections;

public class mictest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach (string device in Microphone.devices) {
			Debug.Log ("Name: " + device);
	
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
