using UnityEngine;
using System.Collections;

public class trampoline : MonoBehaviour {

    public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Rigidbody playerRb = col.gameObject.GetComponent<Rigidbody>();
            playerRb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
        }
    }
}
