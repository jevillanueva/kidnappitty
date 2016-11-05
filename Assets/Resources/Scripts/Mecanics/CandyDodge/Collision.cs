using UnityEngine;
using System.Collections;

public class Collision : miniGameBasic {
	GameObject iniciarTimer;
	void Start(){
		managerGame = GameObject.FindGameObjectWithTag ("master");
		iniciarTimer = GameObject.FindGameObjectWithTag ("timer");
		iniciarTimer.GetComponent<timeController> ().timerOn = true;
	}

	void OnTriggerEnter2D(Collider2D col) 
	{
		//Debug.Log (col.tag);
		if(col.gameObject.tag == "Enemy")
		{
			iniciarTimer.GetComponent<timeController> ().limpiarTimer ();

			Destroy(col.gameObject);
			miniGameStatus = false;
			endMiniGame ();
		}
	}
}
