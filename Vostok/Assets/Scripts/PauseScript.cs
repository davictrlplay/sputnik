using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

	public bool paused;
	public GameObject pauseButton;
	public GameObject mainMenuButton;
	public GameObject backButton;
	public GameObject pausedText;

	// Use this for initialization
	void Start () {
		paused = false;

		pauseButton.SetActive (true);
		pausedText.SetActive (false);
		mainMenuButton.SetActive (false);
		backButton.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Pause(){

		pauseButton.SetActive (false);
		pausedText.SetActive (true);
		mainMenuButton.SetActive (true);
		backButton.SetActive (true);
		Time.timeScale = 0;
	
	}

	public void GoToMainMenu(){

		SceneManager.LoadScene ("Main Menu");
	}

	public void goBack(){
		Time.timeScale = 1;
		pauseButton.SetActive (true);
		pausedText.SetActive (false);
		mainMenuButton.SetActive (false);
		backButton.SetActive (false);

	}
}