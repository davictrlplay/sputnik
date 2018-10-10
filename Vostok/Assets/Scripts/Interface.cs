using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour {



	public GameObject MainMenu;
	public GameObject OptionsMenu;
	public GameObject CreditsMenu;
	public GameObject LevelSelectorMenu;
	public List<GameObject> LevelSelectButtons;



	// Use this for initialization
	void Start () {
		
		LevelSelectButtons = new List<GameObject> ();
		MainMenu.SetActive (true);
		OptionsMenu.SetActive (false);
		CreditsMenu.SetActive (false);
		LevelSelectorMenu.SetActive (false);

		int tempChildCount = LevelSelectorMenu.transform.childCount;

		for (int i = 0; i < tempChildCount - 1; i++) {

			LevelSelectButtons.Add(LevelSelectorMenu.transform.GetChild(i).gameObject);
			LevelSelectButtons [i].SetActive (false);
			Debug.Log (LevelSelectorMenu.transform.GetChild (i).name);
		}

		for (int i = 0; i < PlayerPrefs.GetInt ("LastUnlockedLevel"); i++) {

			LevelSelectButtons [i].SetActive (true);
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		//LÓGICA LEVEL SELECT

	}
		

	//OptConfig
	public void AbrirOpt()
	{
		MainMenu.SetActive (false);
		OptionsMenu.SetActive (true);
	}
	public void VoltarOpt()
	{
		MainMenu.SetActive (true);
		OptionsMenu.SetActive (false);
	
	}

	//OptCreditos
	public void VoltarCr()
	{
		MainMenu.SetActive (true);
		CreditsMenu.SetActive (false);

	}

	public void AbrirCr()
	{
		MainMenu.SetActive (false);
		CreditsMenu.SetActive (true);
		Debug.Log ("ENTROU NOS CREDITOS");

	}

	//OptAbrirLevelSelector
	public void AbrirLvSl()
	{
		MainMenu.SetActive (false);
		LevelSelectorMenu.SetActive (true);


	}

	public void VoltarLvSl()
	{
		MainMenu.SetActive (true);
		LevelSelectorMenu.SetActive (false);
	}

	public void Lv1Select(){

		PlayerPrefs.SetInt ("CurrentLevel", 1);
		SceneManager.LoadScene ("SceneOneTest");

	}

	public void Lv2Select(){

		PlayerPrefs.SetInt ("CurrentLevel", 2);
		SceneManager.LoadScene ("SceneOneTest");

	}

	public void Lv3Select(){

		PlayerPrefs.SetInt ("CurrentLevel", 3);
		SceneManager.LoadScene ("SceneOneTest");

	}

	public void Lv4Select(){

		PlayerPrefs.SetInt ("CurrentLevel", 4);
		SceneManager.LoadScene ("SceneOneTest");

	}

	public void Lv5Select(){

		PlayerPrefs.SetInt ("CurrentLevel", 5);
		SceneManager.LoadScene ("SceneOneTest");

	}
	public void Lv6Select(){

		PlayerPrefs.SetInt ("CurrentLevel", 6);
		SceneManager.LoadScene ("SceneOneTest");

	}


	public void RestartPlayerPrefs(){
		
			PlayerPrefs.SetInt ("CurrentLevel", 1);
			Debug.Log ("Player Prefs criado \"CurrentLevel\", 1");
			PlayerPrefs.SetInt ("IsFirstPlay", 1);
			Debug.Log ("Player Prefs criado \"IsFirstPlay\", 1");
			PlayerPrefs.SetInt ("LastUnlockedLevel", 1);
			Debug.Log ("Player Prefs criado \"LastPlayedLevel\", 1)");
			PlayerPrefs.SetInt ("PlayerScore", 0);
			Debug.Log ("Player Prefs criado \"PlayerScore\", 1)");
			PlayerPrefs.SetInt ("WorldsUnlocked", 1);
			Debug.Log ("Player Prefs criado \"WorldsUnlocked\", 1");

			SceneManager.LoadScene ("Main Menu");
	}


}

















