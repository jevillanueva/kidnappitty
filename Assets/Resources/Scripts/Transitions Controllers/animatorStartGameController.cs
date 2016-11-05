using UnityEngine;
using System.Collections;

public class animatorStartGameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void finishAnimation(){
		GameObject managerGame = GameObject.FindGameObjectWithTag ("master");
		managerGame.GetComponent<generalManager> ().swIntTransition = false;
	}
}
