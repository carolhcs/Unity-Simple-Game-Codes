using UnityEngine;
using System.Collections;

public class ALGC_Prototipo_FDEC_DesativaMoedas : MonoBehaviour {
	//Esse código desativa o objeto da cena
	void OnCollisionEnter2D(Collision2D coll) {
		//Destruir
		gameObject.SetActive(false);
	}
}
