using UnityEngine;
using System.Collections;

public class movementLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void animarGlass(){
		GameObject vaso = GameObject.Find ("glass");
		vaso.GetComponent<Animator> ().SetBool ("swStart", true);
		GameObject managerLight = GameObject.Find ("GameManagerLuz");
		managerLight.GetComponent<mecanicAcelerometer> ().swStart = true;
	}
}
