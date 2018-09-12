using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsInitializer : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//Verifica a existencia dos PlayerPrefs e os cria caso haja necessidade

		if (!PlayerPrefs.HasKey ("CurrentLevel")) {

			PlayerPrefs.SetInt ("CurrentLevel", 1);
		}


		if (!PlayerPrefs.HasKey ("LastLevel")) {

			PlayerPrefs.SetInt ("LastLevel", 1);
		}


		if (!PlayerPrefs.HasKey ("PlayerScore")) {

			PlayerPrefs.SetInt ("PlayerScore", 0);
		}

		if (!PlayerPrefs.HasKey ("WorldsUnlocked")) {

			PlayerPrefs.SetInt ("WorldsUnlocked", 1);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
