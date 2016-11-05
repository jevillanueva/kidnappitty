using UnityEngine;
using System.Collections;
using FMODUnity;
public class generalManager : MonoBehaviour {
	public int score;
	public int highScore;
	public GameObject[] miniGameFactory;
	public float[] timersMiniGame;
	public GameObject transitionStartGame;
	public GameObject transitionGameOver;
	public GameObject transitionWinGame;
	public GameObject transitionLoseGame;
	public int lives = 4;
	public bool miniGameStatus;
	public fase[] fases;
	public int faseActual;
	public int subfase;
	public enum currentStatus {inMiniGame, inTransitionWin, inTransitionLose, inGameOver, inStartGame,inHub}
	public currentStatus actualCurrentStatus = currentStatus.inStartGame;
	public bool endMiniGame;
	public bool swControl;
	public bool swIntTransition;
	public GameObject cameractual;
	// Use this for initialization
	void Awake(){
		cameractual = GameObject.FindGameObjectWithTag ("MainCamera");
//		this.gameObject.GetComponent<StudioParameterTrigger> ().Emitters[] = cameractual.GetComponent<StudioEventEmitter>();
		initGame ();
	}
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (swControl) {
			swControl = false;
			switch (actualCurrentStatus) {
			case currentStatus.inStartGame: 
//			StartCoroutine (startGameTransition ());
				startGameTransition ();
				swControl = true;
				break;
			case currentStatus.inHub: 
//			StartCoroutine (inhubcorrutine ());
				inhubcorrutine ();
				swControl = true;
				break;
			case currentStatus.inGameOver: 
//			StartCoroutine (inGameOver ());
				inGameOver ();
				swControl = true;
				break;

			case currentStatus.inMiniGame: 
//			StartCoroutine (inMiniGameCorrutine ());
				inMiniGameCorrutine ();
				swControl = true;
				break;
			case currentStatus.inTransitionWin: 
//			StartCoroutine (inTransitionWinCorrutine ());
				inTransitionWinCorrutine ();
				swControl = true;
				break;
			case currentStatus.inTransitionLose: 
//			StartCoroutine (inTransitionLoseCorrutine ());
				inTransitionLoseCorrutine ();
				swControl = true;
				break;
			}
		}
	}
	public void initGame(){
		Destroy(GameObject.FindGameObjectWithTag("game"));
		Destroy(GameObject.FindGameObjectWithTag("transition"));
		swControl = true;
		score = 0;
		highScore = PlayerPrefs.GetInt ("HighScore");
		lives = 4;
		miniGameStatus = true;
		subfase = 0;
		faseActual = 0;
		fases = new fase[4];
		fases [0] = new fase (1, 1, 1);
		fases [1] = new fase (1, 1, 1);
		fases [2] = new fase (1, 1, 1);
		fases [3] = new fase (1, 1, 1);
		actualCurrentStatus = currentStatus.inStartGame;

		Debug.Log ("estart");
		swIntTransition = true;
		Instantiate (transitionStartGame);
	}
	void startGameTransition(){
		//generar prefab animation start generar piso personas y inicia correr
		if (!swIntTransition) {
			
			actualCurrentStatus = currentStatus.inHub;
		} else {
			Debug.Log ("En Animacion");
		}


//		yield return new WaitForSeconds (1);
	}
	void inhubcorrutine(){
		if (lives == 0) {
			/// elimina escenario actual
			/// genera el lose
			Destroy(GameObject.FindGameObjectWithTag("game"));
			swIntTransition = true;
			Instantiate (transitionGameOver);
			actualCurrentStatus = currentStatus.inGameOver;
//			yield return new WaitForSeconds (1);
		} else {
			// generar el minijuego y elimina transicion actual

			verifyFase();
			miniGameStatus = true;
			Destroy(GameObject.FindGameObjectWithTag("transition"));
			int randomID = Random.Range (0, miniGameFactory.Length);
			GameObject timer = GameObject.FindGameObjectWithTag ("timer");
			timer.GetComponent<timeController> ().setMaxValue (timersMiniGame[randomID]);
			timer.GetComponent<timeController> ().clearTimer ();
			Instantiate(miniGameFactory[randomID]);
			actualCurrentStatus = currentStatus.inMiniGame;

			endMiniGame = false;
//			yield return new WaitForSeconds (1);
		}

	}
	public void verifyFase(){
		if (subfase > 4 && faseActual < 3) {
			faseActual += 1;
			subfase = 0;
			// to do animacion faster faster
		} else {
			subfase++;
		}
	}

	void inGameOver(){
		/// cambiar la musica
		/// eliminar actual
//		generar la animacion de lose 
//		actualCurrentStatus = currentStatus.;
		if(score> highScore){
			PlayerPrefs.SetInt ("HighScore", score);
			// nuevo high score sound and text
		}
//		yield return new WaitForSeconds (1);
	}

	void inMiniGameCorrutine(){
		Debug.Log ("sGG");
	//// hasta que responda el managaer basic
		if (endMiniGame) {
			Destroy (GameObject.FindGameObjectWithTag ("game"));
			if (miniGameStatus) {
				swIntTransition = true;
				score += 1;
				//Destroy(GameObject.FindGameObjectWithTag("game"));
				swIntTransition = true;
				Instantiate (transitionWinGame);
				actualCurrentStatus = currentStatus.inTransitionWin;
			} else {
				swIntTransition = true;
				if (lives > 0) {
					lives--;
				}
				//Destroy(GameObject.FindGameObjectWithTag("game"));
				swIntTransition = true;
				Instantiate (transitionLoseGame);
				actualCurrentStatus = currentStatus.inTransitionLose;
			}
//			yield return new WaitForSeconds (1);

		} else {
			Debug.Log ("No termino el minijuego");
//			yield return new WaitForSeconds (1);
		}

	}

	void inTransitionWinCorrutine(){
		
		/// generar animacion win
		if (!swIntTransition) {
			actualCurrentStatus = currentStatus.inHub;
		} else {
			Debug.Log ("No termino la transicion del win");
		}

//		yield return new WaitForSeconds (1);
	}
	void inTransitionLoseCorrutine(){

		if (!swIntTransition) {
			actualCurrentStatus = currentStatus.inHub;
		} else {
			Debug.Log ("No termino la transicion del lose");
		}
		/// generar animacion lose
//		actualCurrentStatus = currentStatus.inHub;
//		yield return new WaitForSeconds (1);
	}
}
