using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class ALGC_Prototipo_FDEC_CarregarPontos : MonoBehaviour {

	public Text MoedasBTxt_2;
	public Text MoedasPTxt_2;
	public Text MoedasOTxt_2;
	public Text PontosTxt_2;
	public int pontos_2 = 0;
	public int moedasB_2 = 0;
	public int moedasP_2 = 0;
	public int moedasO_2 = 0;

	void Start () {
		pontos_2 = PlayerPrefs.GetInt ("PlayerPontos");
		moedasB_2 = PlayerPrefs.GetInt ("MoedasBronze");
		moedasP_2 = PlayerPrefs.GetInt ("MoedasPrata");
		moedasO_2 = PlayerPrefs.GetInt ("MoedasOuro");
		PontosTxt_2.text = pontos_2.ToString();
		MoedasBTxt_2.text = moedasB_2.ToString();
		MoedasPTxt_2.text = moedasP_2.ToString();
		MoedasOTxt_2.text = moedasO_2.ToString ();
	}

}
