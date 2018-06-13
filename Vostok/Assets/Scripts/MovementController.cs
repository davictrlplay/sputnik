using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

	public float f_force;
	public Rigidbody rb_person;

	// Use this for initialization
	void Start () {
		rb_person = this.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.W)) {
			rb_person.AddForce (Vector3.forward);	
		
		}

		if (Input.GetKey (KeyCode.S)) {
			rb_person.AddForce (Vector3.back);
		
		}

		if (Input.GetKey (KeyCode.D)) {
			this.transform.Translate (Vector3.right);
		
		}
	}
}
