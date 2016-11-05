using UnityEngine;
using System.Collections;

public class movementGlass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void animarLuz(){
		GameObject luz = GameObject.Find ("LightZone");
		luz.GetComponent<Animator> ().SetBool ("swStart", true);
	}
}
