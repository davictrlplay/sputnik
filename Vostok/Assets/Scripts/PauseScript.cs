using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour {

	public bool paused;

	// Use this for initialization
	void Start () {
		paused = false;
	}

	// Update is called once per frame
	void Update () {

	}
	public void Pause(){

		Debug.Log ("Entrou no pause");
		paused = !paused;

		if (paused) {
			Time.timeScale = 0;
		} else if (!paused) {
			Time.timeScale = 1;
		}



	}	
}