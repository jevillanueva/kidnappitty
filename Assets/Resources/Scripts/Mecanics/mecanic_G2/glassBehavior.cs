using UnityEngine;
using System.Collections;

public class glassBehavior : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay2D(Collider2D other) {
		Debug.Log ("observing");

	}
	void OnTriggerExit2D(Collider2D other) {
		Debug.Log ("Exit");

	}
}
