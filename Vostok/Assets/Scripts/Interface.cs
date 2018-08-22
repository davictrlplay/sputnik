using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour {



	public GameObject MainMenu;
	public GameObject OptionsMenu;
	public GameObject CreditsMenu;
	public GameObject LevelSelectorMenu;



	// Use this for initialization
	void Start () {

//			MainMenu = GameObject.FindWithTag ("MainMenu");
////		OptionsMenu = GameObject.Find ("OptionsMenu");
////		CreditsMenu = GameObject.Find ("CreditsMenu");
////		LevelSelectorMenu = GameObject.Find ("LevelSelectorMenu");
//	
		MainMenu.SetActive (true);
		OptionsMenu.SetActive (false);
		CreditsMenu.SetActive (false);
		LevelSelectorMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}

	//ConfigB

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


}

















