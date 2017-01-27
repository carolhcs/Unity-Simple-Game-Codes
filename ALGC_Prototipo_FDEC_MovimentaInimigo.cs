using UnityEngine;
using System.Collections;

public class ALGC_Prototipo_FDEC_MovimentaInimigo : MonoBehaviour {

	//Movimenta inimigos para cima e para baixo
	// Velocidade de movimento (0 parado)
	public float speed = 1;
	// Switch Movement Direction every x seconds
	public float switchTime = 2;
	void Start() {
		// Direção de movimento inicial
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
		// Switch every few seconds
		InvokeRepeating("Switch", 0, switchTime);
	}
	void Switch() {
		GetComponent<Rigidbody2D>().velocity *= -2;
	}
}
