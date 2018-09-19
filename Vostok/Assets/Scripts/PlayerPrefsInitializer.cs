﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsInitializer : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//Verifica a existencia dos PlayerPrefs e os cria caso haja necessidade

		if (!PlayerPrefs.HasKey ("CurrentLevel")) {

			PlayerPrefs.SetInt ("CurrentLevel", 1);
			Debug.Log ("Player Prefs criado \"CurrentLevel\", 1");
		}


		if (!PlayerPrefs.HasKey ("LastPlayedLevel")) {

			PlayerPrefs.SetInt ("LastPlayedLevel", 1);
			Debug.Log ("Player Prefs criado \"LastPlayedLevel\", 1)");
		}


		if (!PlayerPrefs.HasKey ("PlayerScore")) {

			PlayerPrefs.SetInt ("PlayerScore", 0);
			Debug.Log ("Player Prefs criado \"PlayerScore\", 1)");
		}

		if (!PlayerPrefs.HasKey ("WorldsUnlocked")) {

			PlayerPrefs.SetInt ("WorldsUnlocked", 1);
			Debug.Log ("Player Prefs criado \"WorldsUnlocked\", 1");
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		//HAX

		if (Input.GetKeyDown (KeyCode.Alpha1)) {

			PlayerPrefs.SetInt ("CurrentLevel", 1);
			Debug.Log ("PlayerPrefs.SetInt (\"CurrentLevel\", 1);");

		}


		if (Input.GetKeyDown (KeyCode.Alpha2)) {

			PlayerPrefs.SetInt ("CurrentLevel", 2);
			Debug.Log ("PlayerPrefs.SetInt (\"CurrentLevel\", 2);");

		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {

			PlayerPrefs.SetInt ("CurrentLevel", 3);
			Debug.Log ("PlayerPrefs.SetInt (\"CurrentLevel\", 3);");

		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) {

			PlayerPrefs.SetInt ("CurrentLevel", 4);
			Debug.Log ("PlayerPrefs.SetInt (\"CurrentLevel\", 4);");

		}

		if (Input.GetKeyDown (KeyCode.Alpha5)) {

			PlayerPrefs.SetInt ("CurrentLevel", 5);
			Debug.Log ("PlayerPrefs.SetInt (\"CurrentLevel\", 5);");

		}

		if (Input.GetKeyDown (KeyCode.Alpha6)) {

			PlayerPrefs.SetInt ("CurrentLevel", 6);
			Debug.Log ("PlayerPrefs.SetInt (\"CurrentLevel\", 6);");

		}



		
	}
		
}
