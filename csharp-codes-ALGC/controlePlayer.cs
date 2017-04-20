//Carol Salvato HCS -- algamecode.blogspot.com
//Antes de tudo crie as tags das portas e coloque cada tag em cada porta como mostrado no esquema do desenho que vou te mandar
//Não esqueça de no player e nas portas usar Rigidbody para detectar a colisão
//Não esqueça de adicionar as cenas no buildSettings para não ter erro na transição

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlePlayer : MonoBehaviour {

	//Movimentação Básica //Bugada Ignore
	public float speed = 5.0f;
	public float rotateSpeed = 3.0f;

	//Variaveis
	//Guardar o comodo anterior e capturar o atual ao carregar a cena para entender de onde o personagem veio e definir sua posição.
	public int cenaComodoAtual = 0;
	public int cenaComodoAnterior = 0;


	void Start () {
		//Carrega salas anterior e atual
		cenaComodoAnterior = PlayerPrefs.GetInt ("ComodoAnterior");
		cenaComodoAtual = PlayerPrefs.GetInt ("ComodoAtual");
		//Condição que defini posição do personagem baseado nas salas atual e anterior
		if (cenaComodoAtual == 0 && cenaComodoAnterior == 0) {
			transform.position = new Vector3 (-3.50f, 1.30f, -1.70f); //Manda o personagem para a posição X, Y, Z definida
		} else if (cenaComodoAtual == 0 && cenaComodoAnterior == 1) {
			transform.position = new Vector3 (-3.50f, 1.30f, -1.70f);
		} else if (cenaComodoAtual == 1 && cenaComodoAnterior == 0) {
			transform.position = new Vector3 (-3.50f, 1.30f, 9.43f);
		} else if (cenaComodoAtual == 1 && cenaComodoAnterior == 2) {
			transform.position = new Vector3 (-3.50f, 1.30f, -1.70f);
		} else if (cenaComodoAtual == 2 && cenaComodoAnterior == 1) {
			transform.position = new Vector3 (-3.50f, 1.30f, 9.43f);
		}
		//Nesse caso as posições são parecidas porque as salas tem o mesmo tamanho e estão na mesma posição, mas use o transform do player para ver a posição que quer que ele vá
	}
	

	void Update () {

		//Movimentação Básica //Bugada Ignore
		CharacterController controller = GetComponent<CharacterController>();
		transform.Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		float ourSpeed = speed * Input.GetAxis ("Vertical");
		controller.SimpleMove (forward * ourSpeed);

	}

	//Colisão
	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.tag == "portaInfSala00"){
			//Se estou colidindo com a porta onferior da sala um então minha sala anterior sera 0 e minha nova sala sera 1
			cenaComodoAnterior = 0;
			cenaComodoAtual = 1;
			PlayerPrefs.SetInt ("ComodoAnterior", cenaComodoAnterior); //Grava temporariamente para carregar após troca de cena
			PlayerPrefs.SetInt ("ComodoAtual", cenaComodoAtual);
			SceneManager.LoadScene ("Cena02");//Muda de cena

		} else if(coll.gameObject.tag == "portaSupSala00"){
			//Trancada pois não há sala a cima
			//Você pode mostrar uma mensagem de trancada ou simplesmente excluir essa porta
		} else if(coll.gameObject.tag == "portaInfSala01"){
			cenaComodoAnterior = 1;
			cenaComodoAtual = 2;
			PlayerPrefs.SetInt ("ComodoAnterior", cenaComodoAnterior);
			PlayerPrefs.SetInt ("ComodoAtual", cenaComodoAtual);
			SceneManager.LoadScene ("Cena03");

		} else if(coll.gameObject.tag == "portaSupSala01"){
			cenaComodoAnterior = 1;
			cenaComodoAtual = 0;
			PlayerPrefs.SetInt ("ComodoAnterior", cenaComodoAnterior);
			PlayerPrefs.SetInt ("ComodoAtual", cenaComodoAtual);
			SceneManager.LoadScene ("Cena01");

		} else if(coll.gameObject.tag == "portaInfSala02"){
			//Trancada pois não há sala a baixo
			//Você pode mostrar uma mensagem de trancada ou simplesmente excluir essa porta
		} else if(coll.gameObject.tag == "portaSupSala02"){
			cenaComodoAnterior = 2;
			cenaComodoAtual = 1;
			PlayerPrefs.SetInt ("ComodoAnterior", cenaComodoAnterior);
			PlayerPrefs.SetInt ("ComodoAtual", cenaComodoAtual);
			SceneManager.LoadScene ("Cena02");

		}
	}


}