using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

	public float f_force; // Variavel criada para força
	public int i_forceLevel; // Variavel criada para contar o nivel da força
	public float f_sides; // Variavel criada para força dos lados
	private float seconds;
	private int i;
	private int i_forceUp;
	public Rigidbody rb_person; 

	// Use this for initialization
	void Start () {
		rb_person = this.GetComponent<Rigidbody> ();
		f_force = 30f; // Adiciona o valor de 5 à variavel f_force
		f_sides = 4f; // Adiciona o valor de 4 à variavel f_sides
		i_forceLevel = 0; // Adiciona o valor de 0 para o nivel da força
		i_forceUp = 50;
	}

	// Update is called once per frame
	void Update () {

		//Para aumentar a velocidade do objeto
		if (Input.GetKeyDown (KeyCode.W)) { //Se a tecla pressionada for W
			if (i_forceLevel <= 10) { //Se o nivel da força for menor/igual a 10
				rb_person.AddForce (Vector3.forward * f_force); //Adiciona força para frente no objeto
				i_forceLevel++; //Adiciona o valor de 1 para o nivel da força
				Debug.Log ("Vel Level: " + i_forceLevel);
			} else {
				Debug.Log ("You cant add more force, the max velocitys level is 10");
			}	
		}

		//Para diminuir a velocidade do objeto
		if (Input.GetKeyDown (KeyCode.S)) { //Se a tecla pressionada for S
			if (i_forceLevel >= 1) { //Se o nivel da força for maior/igual a 1
				rb_person.AddForce (Vector3.back * f_force); //Adiciona força para trás no objeto
				i_forceLevel--; //Subtrai o valor de 1 para o nivel da força
				Debug.Log ("Vel Level: " + i_forceLevel);
			} else {
				Debug.Log ("You cant remove more force, the min velocitys level is 0");
			}
		}

		//Para ir para direita
		if (Input.GetKeyDown (KeyCode.D)) { //Se a tecla pressionada for D
			this.transform.Translate (f_sides, 0f, 0f); //Adiciona o valor de f_sides para o eixo.X usando o transform
		}

		//Para ir para esquerda
		if (Input.GetKeyDown (KeyCode.A)) { //Se a tecla pressionada for A
			this.transform.Translate (-f_sides, 0f, 0f); //Remove o valor de f_sides para o eixo.X usando o transform
		}

		if (Input.GetKeyDown (KeyCode.Space)) { //Se a tecla pressionada for Space	
			for (i = 0; i < i_forceLevel; i++) { //Para i igual a zero, aumentar até valor de i_forceLevel
				if (i_forceLevel < 3) { //Se i_forceLever for menor que 6
					rb_person.AddForce (Vector3.up * (i_forceUp * i_forceLevel)); //Adiciona força no vetor 3 para cima
				} else { //Caso for maior que 6
					rb_person.AddForce (Vector3.up * i_forceUp); //Adiciona força de i_forceUp
				}
			}	
		}
	}
}

