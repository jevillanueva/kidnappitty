using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour {
	public GameObject clickSound;
	// Use this for initialization
	GameObject toDelete2;
	void Start () {
		GameObject toDelete = GameObject.FindGameObjectWithTag ("miniMaster");
		toDelete2 = GameObject.FindGameObjectWithTag ("miniMaster2");
		Destroy (toDelete);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void iniciarjuego(){
		Instantiate (clickSound);

		Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
		Destroy (toDelete2);
		SceneManager.LoadScene (1);
	}
	public void repetirTodo(){
		SceneManager.LoadScene (1);
//		GameObject managerGame = GameObject.FindGameObjectWithTag ("master");
//
//		managerGame.GetComponent<generalManager> ().initGame ();
//		Destroy (this.gameObject);
//		Debug.Log ("asdd");
	}
}
