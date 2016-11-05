using UnityEngine;
using System.Collections;

public class miniGameBasic : MonoBehaviour {
	public bool miniGameStatus;
	public GameObject managerGame;
	// Use this for initialization
	void Start () {
//		managerGame = GameObject.FindGameObjectWithTag ("master");
		miniGameStatus = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void endMiniGame(){
		
		generalManager manager = managerGame.GetComponent<generalManager> ();
		manager.miniGameStatus = miniGameStatus;
		manager.endMiniGame = true;

	}

}
