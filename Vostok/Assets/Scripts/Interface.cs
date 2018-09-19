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

		for (int i = 0; i < PlayerPrefs.GetInt ("CurrentLevel"); i++) {

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

		SceneManager.LoadScene ("SceneOneTest");
	}

	public void RestartMainMenu(){

		SceneManager.LoadScene ("Main Menu");
	}


}

















