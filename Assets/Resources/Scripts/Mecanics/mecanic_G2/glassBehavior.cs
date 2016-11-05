using UnityEngine;
using System.Collections;

public class glassBehavior : miniGameBasic {
	public bool swTiempoFuera;
	public float tiempoFuera = 1;
	public float tiempo;
	public bool inGamePlay;
		// Use this for initialization
	void Start () {
		managerGame = GameObject.FindGameObjectWithTag ("master");
		tiempo = 0;
		swTiempoFuera = false;
		inGamePlay = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (swTiempoFuera) {
			tiempo+=Time.deltaTime;
		}
		if (tiempo > tiempoFuera) {
			GameObject iniciarTimer = GameObject.FindGameObjectWithTag ("timer");
			iniciarTimer.GetComponent<timeController> ().limpiarTimer ();
			miniGameStatus = false;
			endMiniGame ();
		}
	}
	void OnTriggerStay2D(Collider2D other) {
		Debug.Log ("observing");
		swTiempoFuera = false;
		tiempo = 0;
	}
	void OnTriggerExit2D(Collider2D other) {
		if(inGamePlay)
			swTiempoFuera = true;
		Debug.Log ("Exit");

	}
}
