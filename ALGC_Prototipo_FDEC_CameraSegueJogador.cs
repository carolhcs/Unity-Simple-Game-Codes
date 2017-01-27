using UnityEngine;
using System.Collections;

public class ALGC_Prototipo_FDEC_CameraSegueJogador : MonoBehaviour {
	//Esse código faz a camera seguir um trajeto
	public Transform trajeto;
	void LateUpdate () {
		transform.position = new Vector3(trajeto.position.x, transform.position.y, transform.position.z);
	}
}
