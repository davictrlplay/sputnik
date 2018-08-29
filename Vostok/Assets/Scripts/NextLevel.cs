using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	public GameObject placeholder1;
	public GameObject placeholder2;
	public GameObject placeholder3;
	public GameObject placeholder4;
	public Rigidbody rb;
	public int i_forceLevel;

	private int i;
	private int i_level;
	public string s_placeholder;

	void Awake () {
		i_level = 1;
		s_placeholder = "placeholder 1";

		rb = this.GetComponent<Rigidbody> ();
	}

	void Update () {
		i_forceLevel = this.GetComponent<MovementController> ().i_forceLevel;
	}

	void OnCollisionEnter (Collision Coll) {
		if (Coll.gameObject.tag == "NextLevel") {
			//for (i = 0; i < i_forceLevel; i++) {
			//	this.GetComponent<Rigidbody> ().AddForce (Vector3.forward * this.GetComponent<MovementController> ().f_force);
			//}

			if (i_level == 1) {
				this.transform.position = placeholder2.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				s_placeholder = "placeholder 2";
			}
		
			else if (i_level == 2) {
				this.transform.position = placeholder3.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				s_placeholder = "placeholder 3";
			}

			else if (i_level == 3) {
				this.transform.position = placeholder4.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				s_placeholder = "placeholder 4";
			}
								
		}
	}

}
