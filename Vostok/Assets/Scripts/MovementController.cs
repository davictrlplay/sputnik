using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour {
	
	public bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
	public bool isDraging;
	public Vector2 startTouch, swipeDelta;


	public float f_force; // Variavel criada para força
	public int i_forceLevel; // Variavel criada para contar o nivel da força
	public float f_sides; // Variavel criada para força dos lados
	private float seconds;
	private int i;
	public int i_forceUp;
	public Rigidbody rb_person; 
	public bool b_isGrounded;

	// Use this for initialization
	void Start () {
		isDraging = false;
		b_isGrounded = false;

		rb_person = this.GetComponent<Rigidbody> ();
		f_force = 30f; // Adiciona o valor de 5 à variavel f_force
		f_sides = 0.5f; // Adiciona o valor de 4 à variavel f_sides
		i_forceLevel = 0; // Adiciona o valor de 0 para o nivel da força
		i_forceUp = 250;
	}

	// Update is called once per frame
	void Update () {

		////////////For Touch and Mouse////////////
		///////////////////////////////////////////

		tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;

		#region Standalone Inputs
		if (Input.GetMouseButtonDown(0)) {
			tap = true;
			isDraging = true;
			startTouch = Input.mousePosition;
		} else if (Input.GetMouseButtonUp(0)) {
			isDraging = false;
			Reset();
		}
		#endregion

		//////
		#region Mobile Inputs
		if (Input.touches.Length > 0) {
			if (Input.touches[0].phase == TouchPhase.Began) {
				tap = true;
				isDraging = true;
				startTouch = Input.touches[0].position;
			} else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled) {
				isDraging = false;
				Reset();
			}
		}
		#endregion

		swipeDelta = Vector3.zero;
		if (isDraging) {
			if (Input.touches.Length > 0) {
				swipeDelta = Input.touches [0].position - startTouch;
			} else if (Input.GetMouseButton (0)) {
				swipeDelta = (Vector2)Input.mousePosition - startTouch;
			}
		}

		if (swipeDelta.magnitude > 125) {
			float x = swipeDelta.x;
			float y = swipeDelta.y;

			if (Mathf.Abs (x) > Mathf.Abs (y)) {
				if (x < 0)
					swipeLeft = true;
				else
					swipeRight = true;
			} else {
				if (y < 0)
					swipeDown = true;
				else
					swipeUp = true;

			}

			Reset ();
		}

		///////////////////////////////////////////
		/////////////////////////////////////////// 


		Collider[] isGrounded = Physics.OverlapSphere (this.transform.position, 0.1f);

		//Debug.Log ("POS: " + isGrounded.Length);

		for (int i = 0; i < isGrounded.Length; i++) {
			if (isGrounded [i].gameObject.layer == 8) {
				b_isGrounded = true;
			}
		}

		//Para aumentar a velocidade do objeto
		if (swipeDown || Input.GetKeyDown (KeyCode.W)) { //Se a tecla pressionada for W
			if (i_forceLevel <= 10) { //Se o nivel da força for menor/igual a 10
				rb_person.AddForce (Vector3.forward * f_force); //Adiciona força para frente no objeto
				i_forceLevel++; //Adiciona o valor de 1 para o nivel da força
				//Debug.Log ("Vel Level: " + i_forceLevel);
			} else {
				Debug.Log ("You cant add more force, the max velocitys level is 10");
			}	
		}

		//Para diminuir a velocidade do objeto
		if (Input.GetKey (KeyCode.S)) { //Se a tecla pressionada for S
			if (i_forceLevel >= 1) { //Se o nivel da força for maior/igual a 1
				rb_person.AddForce (Vector3.back * f_force); //Adiciona força para trás no objeto
				i_forceLevel--; //Subtrai o valor de 1 para o nivel da força
				//Debug.Log ("Vel Level: " + i_forceLevel);
			} else {
				Debug.Log ("You cant remove more force, the min velocitys level is 0");
			}
		}

		//Para ir para direita
		if (swipeRight || Input.GetKeyDown (KeyCode.D)) { //Se a tecla pressionada for D
			this.transform.Translate (f_sides, 0f, 0f); //Adiciona o valor de f_sides para o eixo.X usando o transform
		}

		//Para ir para esquerda
		if (swipeLeft || Input.GetKeyDown (KeyCode.A)) { //Se a tecla pressionada for A
			this.transform.Translate (-f_sides, 0f, 0f); //Remove o valor de f_sides para o eixo.X usando o transform
		}

		if (swipeUp && b_isGrounded || Input.GetKeyDown (KeyCode.Space) && b_isGrounded) { //Se a tecla pressionada for Space
			Debug.Log ("Pulo");
			rb_person.AddForce (Vector3.up * i_forceUp); //Adiciona força de i_forceUp
			b_isGrounded = false;
		}

	}
		
	public void Reset() {
		startTouch = swipeDelta = Vector3.zero;
		isDraging = false;
	}

	public Vector3 SwipeDelta { get { return swipeDelta; } }
	public bool SwipeLeft { get { return swipeLeft; } }
	public bool SwipeRight { get { return swipeRight; } }
	public bool SwipeUp { get { return swipeUp; } }
	public bool SwipeDown { get { return swipeDown; } }

}


