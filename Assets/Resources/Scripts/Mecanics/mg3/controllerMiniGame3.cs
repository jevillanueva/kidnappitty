using UnityEngine;
using System.Collections;

public class controllerMiniGame3 : miniGameBasic {
	public GameObject sonidoError;
	// Use this for initialization
	void Start () {
		managerGame = GameObject.FindGameObjectWithTag ("master");
		GameObject iniciarTimer = GameObject.FindGameObjectWithTag ("timer");
		iniciarTimer.GetComponent<timeController> ().timerOn = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void touchButon(){
		Instantiate (sonidoError);
		GameObject iniciarTimer = GameObject.FindGameObjectWithTag ("timer");

		iniciarTimer.GetComponent<timeController> ().limpiarTimer ();
		miniGameStatus = false;
		endMiniGame ();
	}
}
