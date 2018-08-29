using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour {

	public int i;
	public bool isGrounded;

	void OnCollisionEnter (Collision col)  //função da colisão
	{
		if (col.gameObject.name == "Person") 
		{ 

			col.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			col.gameObject.GetComponent<MovementController> ().i_forceLevel = 0;
			col.gameObject.transform.position = GameObject.Find(col.gameObject.GetComponent<NextLevel> ().s_placeholder).transform.position;

		}

			
	}

}
