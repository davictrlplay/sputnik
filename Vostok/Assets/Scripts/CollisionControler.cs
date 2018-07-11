using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour {
	
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Person") {
			Destroy (col.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

