using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour {

	public int i;
	//public string s_placeholder;
	//public float f_force;

	//public GameObject;

	//void Awake () {
	//	s_placeholder = 
	//}

	void OnCollisionEnter (Collision col)  //função da colisão
	{
		if (col.gameObject.name == "Person") 
		{ 
			for (i = 0; i < col.gameObject.GetComponent<MovementController> ().i_forceLevel; i++) {
				col.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.forward * (col.gameObject.GetComponent<MovementController> ().f_force));
			}
			col.gameObject.transform.position = GameObject.Find(col.gameObject.GetComponent<NextLevel> ().s_placeholder).transform.position;

		}
	}

}
