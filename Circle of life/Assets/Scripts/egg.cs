using UnityEngine;
using System.Collections;

public class egg : MonoBehaviour {

    public float speed;
    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddTorque(new Vector3(0, 0, horizontal * speed), ForceMode.Force);

	}
}
