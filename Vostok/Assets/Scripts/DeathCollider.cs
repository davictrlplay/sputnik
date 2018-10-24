using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour {

	public string currentPlaceHolder;

	void OnCollisionEnter (Collision death)  {
		if (death.gameObject.name == "Person") { 
			restartLevel (1);
		}
	}

	public void restartLevel (int level) {
		if (level == 1) {
			GameObject.Find("Person").transform.position = GameObject.Find(currentPlaceHolder).transform.position;
			GameObject.Find("Person").GetComponentInChildren<Animator> ().speed = 0f;
		}

	}

}
