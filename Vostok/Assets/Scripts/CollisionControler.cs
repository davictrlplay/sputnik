using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour {
	void OnCollisionEnter (Collision col) { //Cria a função de colisão
		if (col.gameObject.name == "Person") { //Se o objeto colidido foi "Person"
			col.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0); //Seta a velocidade do objeto colidido como 0
			col.gameObject.GetComponent<MovementController> ().i_forceLevel = 0; //Seta a variavel "i_forceLevel" (está dentro do script MovementController do obj) como 0
			col.gameObject.transform.position = GameObject.Find(col.gameObject.GetComponent<NextLevel> ().s_placeholder).transform.position; //Muda a posição do player para seu respectivo placeholder

		}
	}
}
