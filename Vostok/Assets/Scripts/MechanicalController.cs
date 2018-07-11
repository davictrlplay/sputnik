using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanicalController : MonoBehaviour {
	public Rigidbody rb_person; 
	public Rigidbody velocity;

	void Start () {
		rb_person = this.GetComponent<Rigidbody> (); //Variavel que pega o componente rigidbody
	}

	void Update() {

	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Booster") {
			Debug.Log ("Boosting");
			Destroy (col.gameObject);
			rb_person.AddForce (Vector3.forward * 1000f);
		}
		if (col.gameObject.tag == "Breaker") {
			Debug.Log ("Breaking");
			Destroy (col.gameObject);
			rb_person.AddForce (Vector3.back * 250f);
		}
	}

}

