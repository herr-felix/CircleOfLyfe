using UnityEngine;
using System.Collections;

public class adult : MonoBehaviour {

    bool isWalking = false;
    bool isJumping = false;
    Animator anim;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //anim.SetBool("Jump", false);

	    float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal != 0)
        {
            isWalking = true;
            rb.velocity = new Vector3(-7 * horizontal, rb.velocity.y, 0);
            if (horizontal < 0)
            {
                transform.forward = new Vector3(0, 0, -1);
            }
            else
            {
                transform.forward = new Vector3(0, 0, 1);
            }
        }
        else isWalking = false;

        anim.SetBool("isWalking", isWalking);

        if (Input.GetButton("Jump") && !isJumping)
        {
            isJumping = true;
            anim.SetBool("Jump", true);
            rb.AddForce(new Vector3(horizontal, 7, 0), ForceMode.Impulse);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        isJumping = false;
        anim.SetBool("Jump", false);
    }
}
