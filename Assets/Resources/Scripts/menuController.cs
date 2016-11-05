using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void iniciarjuego(){
		SceneManager.LoadScene (1);
	}
	public void repetirTodo(){
		Debug.Log ("asdd");
	}
}
