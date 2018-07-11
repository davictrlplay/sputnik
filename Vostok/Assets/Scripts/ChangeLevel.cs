using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour {

	public GameObject person;
	private int i;
	private float f_Pforce;
	private int i_PlevelForce;

	// Use this for initialization
	void Start () {
		person = GameObject.Find("Person");
	}
	
	// Update is called once per frame
	void Update () {
		f_Pforce = person.GetComponent<MovementController> ().f_force;
		i_PlevelForce = person.GetComponent<MovementController> ().i_forceLevel;
		Debug.Log ("Force: " + f_Pforce);
		Debug.Log ("LForce: " + i_PlevelForce);
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Person") {
			Debug.Log ("Entrou em colisão.");

			for (i = 0; i < i_PlevelForce; i++) {
				person.GetComponent<Rigidbody> ().AddForce (Vector3.back * f_Pforce);
				person.GetComponent<MovementController> ().i_forceLevel = 0;
			
			}
		}
	}
}
