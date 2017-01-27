using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class ALGC_Prototipo_FDEC_ControleJogador : MonoBehaviour {
	
	public float velocidade = 8; // velocidade de movimento
	public float forca = 300; // força do salto
	public int pontos = 0;
	public int moedasB = 0;
	public int moedasP = 0;
	public int moedasO = 0;
	public GameObject MenuPause;
	public Text MoedasBTxt;
	public Text MoedasPTxt;
	public Text MoedasOTxt;
	public Text PontosTxt;

	void Start () {
		// Voa para a direita
		GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidade;
		Time.timeScale = 0; // Pausa o jogo
	}
	void Update () {
		//Voar
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * forca);
			if (Time.timeScale == 0) {
				MenuPause.gameObject.SetActive (false);
				Time.timeScale = 1;
			}
		}
		PontosTxt.text = pontos.ToString();
		MoedasBTxt.text = moedasB.ToString();
		MoedasPTxt.text = moedasP.ToString();
		MoedasOTxt.text = moedasO.ToString();
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Obstaculo"){
			// Restart
			//Application.LoadLevel(Application.loadedLevel);
			// Comparar pontos e salvar caso entrou no ranking
			PlayerPrefs.SetInt("MoedasBronze", moedasB);
			PlayerPrefs.SetInt("MoedasPrata", moedasP);
			PlayerPrefs.SetInt("MoedasOuro", moedasO);
			PlayerPrefs.SetInt("PlayerPontos", pontos);
			SceneManager.LoadScene ("05GameOver");
		} else if (coll.gameObject.tag == "Moeda01") {
			pontos++;
			moedasB++;
			GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidade;
		} else if (coll.gameObject.tag == "Moeda02") {
			pontos = pontos + 5;
			moedasP++;
			GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidade;
		} else if (coll.gameObject.tag == "Moeda03") {
			pontos = pontos + 10;
			moedasO++;
			GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidade;
		} else if (coll.gameObject.tag == "fimGame"){
			pontos = pontos + 20;
			PlayerPrefs.SetInt("PlayerPontos", pontos);
			SceneManager.LoadScene ("06Venceu");
		}
	}
	public void botaoUp () {
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * forca);
		if (Time.timeScale == 0) {
			MenuPause.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}

}
