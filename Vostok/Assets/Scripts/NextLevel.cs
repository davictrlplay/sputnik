using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	public GameObject fase1;
	public GameObject fase2;
	public GameObject fase3;
	public GameObject fase4;
	public GameObject fase5;
	public GameObject fase6;
	public GameObject fase7;
	public GameObject placeholder1;
	public GameObject placeholder2;
	public GameObject placeholder3;
	public GameObject placeholder4;
	public GameObject placeholder5;
	public GameObject placeholder6;
	public GameObject placeholder7;
	public Rigidbody rb;
	public int i_forceLevel;

	private int i;
	private int i_level;
	public string s_placeholder;

	void Awake () {
		i_level = PlayerPrefs.GetInt ("CurrentLevel");
		Debug.Log (" CurrentLevel " + PlayerPrefs.GetInt ("CurrentLevel").ToString ());
		s_placeholder = "placeholder 1";

		rb = this.GetComponent<Rigidbody> ();

		fase1 = GameObject.Find ("Fase 1");
		fase2 = GameObject.Find ("Fase 2");
		fase3 = GameObject.Find ("Fase 3");
		fase4 = GameObject.Find ("Fase 4");
		fase5 = GameObject.Find ("Fase 5");
		fase6 = GameObject.Find ("Fase 6");
		fase7 = GameObject.Find ("Fase 7");

		placeholder1 = fase1.transform.Find("placeholder 1").gameObject;
		placeholder2 = fase2.transform.Find("placeholder 2").gameObject;
		placeholder3 = fase3.transform.Find("placeholder 3").gameObject;
		placeholder4 = fase4.transform.Find("placeholder 4").gameObject;
		placeholder5 = fase5.transform.Find("placeholder 5").gameObject;
		placeholder6 = fase6.transform.Find("placeholder 6").gameObject;
		placeholder7 = fase7.transform.Find("placeholder 7").gameObject;


		if (i_level == 1) {
			this.transform.position = placeholder1.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 1";

		}

		else if (i_level == 2) {
			PlayerPrefs.SetInt ("IsFirstPlay", 0);
			this.transform.position = placeholder2.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 2";
		}

		else if (i_level == 3) {
			this.transform.position = placeholder3.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 3";
		}

		else if (i_level == 4) {
			this.transform.position = placeholder4.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 4";
		}

		else if (i_level == 5) {
			this.transform.position = placeholder5.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 5";
		}

		else if (i_level == 6) {
			this.transform.position = placeholder6.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 6";
		}

		else if (i_level == 7) {
			this.transform.position = placeholder7.transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
			this.GetComponent<MovementController> ().i_forceLevel = 0;
			s_placeholder = "placeholder 7";
		}
	} //Fim do Awake
		
	void Update () {
		i_forceLevel = this.GetComponent<MovementController> ().i_forceLevel; //Para pegar sempre a variavel "i_forceLevel que está dentro do Script MovimentController deste objeto"

	} //Fim do Update

	void OnCollisionEnter (Collision Coll) {
		if (Coll.gameObject.tag == "NextLevel") {
			if (i_level == 1) {
				this.transform.position = placeholder2.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				PlayerPrefs.SetInt ("CurrentLevel", i_level);
				PlayerPrefs.SetInt ("LastUnlockedLevel", i_level);
				s_placeholder = "placeholder 2";
			}
		
			else if (i_level == 2) {
				this.transform.position = placeholder3.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				PlayerPrefs.SetInt ("CurrentLevel", i_level);
				PlayerPrefs.SetInt ("LastUnlockedLevel", i_level);
				s_placeholder = "placeholder 3";
			}

			else if (i_level == 3) {
				this.transform.position = placeholder4.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				PlayerPrefs.SetInt ("CurrentLevel", i_level);
				PlayerPrefs.SetInt ("LastUnlockedLevel", i_level);
				s_placeholder = "placeholder 4";
			}

			else if (i_level == 4) {
				this.transform.position = placeholder5.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				PlayerPrefs.SetInt ("CurrentLevel", i_level);
				PlayerPrefs.SetInt ("LastUnlockedLevel", i_level);
				s_placeholder = "placeholder 5";
			}

			else if (i_level == 5) {
				this.transform.position = placeholder6.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				i_level++;
				PlayerPrefs.SetInt ("CurrentLevel", i_level);
				PlayerPrefs.SetInt ("LastUnlockedLevel", i_level);
				s_placeholder = "placeholder 6";
			}

			else if (i_level == 6) {
				this.transform.position = placeholder7.transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
				this.GetComponent<MovementController> ().i_forceLevel = 0;
				Debug.Log ("CABO OTÁRIO");
				s_placeholder = "placeholder 7";
			}
								
		}
	}

}
