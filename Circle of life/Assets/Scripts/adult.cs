using UnityEngine;
using System.Collections;

public class adult : MonoBehaviour {

    bool isWalking = false;
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    float horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0) isWalking = true;
        else isWalking = false;

        if (Input.GetButton("Jump"))
            anim.SetBool("Jump", true);
	}
}
