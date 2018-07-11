using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}


	void OnCollisionEnter (Collision col)  //função da colisão
	{
		if (col.gameObject.name == "Person") 
		{ 
			col.gameObject.transform.position = GameObject.Find("Marker1_start").transform.position;
			col.gameObject.GetComponent<Rigidbody>().AddForce (Vector3.forward * gameObject.GetComponent<MovementController> ().f_force * (-1));
		}
	}


	// Update is called once per frame
	void Update () {

	}
}
