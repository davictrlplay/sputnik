using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour {

	void OnCollisionEnter (Collision col)  //função da colisão
	{
		//se o gameObject Person colidir com algum outro objeto será destruído
		if (col.gameObject.name == "Person") 
		{
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

