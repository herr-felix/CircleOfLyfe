using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    Animator anim;
    bool isFlapping = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        isFlapping = Input.GetButton("Jump");
        anim.SetBool("isFlapping", isFlapping);
	}
}
