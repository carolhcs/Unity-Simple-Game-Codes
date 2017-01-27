using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ALGC_Prototipo_FDEC_MudaCena : MonoBehaviour {

	public void btJogar (){
		SceneManager.LoadScene ("02Jogo");
	}
	public void btVoltar (){
		SceneManager.LoadScene ("01MenuPrincipal");
	}
	public void btSobre (){
		SceneManager.LoadScene ("03Sobre");
	}
	public void btRanking (){
		SceneManager.LoadScene ("04Ranking");
	}
	public void btSair (){
		Application.Quit ();
	}
	public void btFacebook (){
		Application.OpenURL("https://www.facebook.com/algamecode/");
	}
	public void btTwitter (){
		Application.OpenURL("https://twitter.com/carol_HCS");
	}
	public void btBlogger (){
		Application.OpenURL("http://algamecode.blogspot.com.br/");
	}
}
