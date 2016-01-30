using UnityEngine;
using System.Collections;

public class playerBehave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//use the movement scripts too

		if(Input.GetButton("Action1")){
			//turn into human form
		}
		if (Input.GetButton ("Action2")) {
			//turn into moose
		}
		if (Input.GetButton ("Action3")) {
			//turn into shark
		}
		if (Input.GetButton ("Action4")) {
			//turn into eagle
		}
		if (Input.GetButton ("Action5")) {
			//turn into pheonix
		}
		if(Input.GetButton("Action6")){
			//turn into shaman?
		}
	
	}

	enum StageOfLife {egg, child, teen, adult, shaman};
	enum Form {human, moose, shark, eagle, pheonix};
}
