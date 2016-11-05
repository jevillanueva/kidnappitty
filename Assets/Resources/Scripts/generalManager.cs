using UnityEngine;
using System.Collections;

public class generalManager : MonoBehaviour {
	public int score;
	public int highScore;
	public GameObject[] miniGameFactory;
	public int lives = 4;
	public bool miniGameStatus;
	public fase[] fases;
	public int faseActual;
	public int subfase;
	public enum currentStatus {inMiniGame, inTransitionWin, inTransitionLose, inGameOver, inStartGame,inHub}
	public currentStatus actualCurrentStatus = currentStatus.inStartGame;
	public bool endMiniGame;
	// Use this for initialization
	void Awake(){
		initGame ();
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (actualCurrentStatus){
		case currentStatus.inStartGame: 
			StartCoroutine (startGameTransition ());
			break;
		case currentStatus.inHub: 
			StartCoroutine (inhubcorrutine ());
			break;
		case currentStatus.inGameOver: 
			StartCoroutine (inGameOver ());
			break;

		case currentStatus.inMiniGame: 
			StartCoroutine (inMiniGameCorrutine ());
			break;
		case currentStatus.inTransitionWin: 
			StartCoroutine (inTransitionWinCorrutine ());
			break;
		case currentStatus.inTransitionLose: 
			StartCoroutine (inTransitionLoseCorrutine ());
			break;
		}
	}
	public void initGame(){
		score = 0;
		highScore = PlayerPrefs.GetInt ("HighScore");
		lives = 4;
		miniGameStatus = false;
		subfase = 0;
		faseActual = 0;
		fases = new fase[4];
		fases [0] = new fase (1, 1, 1);
		fases [1] = new fase (1, 1, 1);
		fases [2] = new fase (1, 1, 1);
		fases [3] = new fase (1, 1, 1);
		actualCurrentStatus = currentStatus.inStartGame;

	}
	IEnumerator startGameTransition(){
		//generar prefab animation start generar piso personas y inicia correr
		actualCurrentStatus = currentStatus.inHub;
		yield return new WaitForSeconds (1);
	}
	IEnumerator inhubcorrutine(){
		if (lives == 0) {
			/// elimina escenario actual
			/// genera el lose 
			actualCurrentStatus = currentStatus.inGameOver;
			yield return new WaitForSeconds (1);
		} else {
			// generar el minijuego y elimina transicion actual
			verifyFase();

			Instantiate(miniGameFactory[Random.Range(0,miniGameFactory.Length)]);
			actualCurrentStatus = currentStatus.inMiniGame;
			yield return new WaitForSeconds (1);
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

	IEnumerator inGameOver(){
		/// cambiar la musica
		/// eliminar actual
//		generar la animacion de lose 
//		actualCurrentStatus = currentStatus.;
		if(score> highScore){
			PlayerPrefs.SetInt ("HighScore", score);
			// nuevo high score sound and text
		}
		yield return new WaitForSeconds (1);
	}

	IEnumerator inMiniGameCorrutine(){
	//// hasta que responda el managaer basic
		if (!endMiniGame) {
			if (miniGameStatus) {
				actualCurrentStatus = currentStatus.inTransitionWin;
			} else {
				actualCurrentStatus = currentStatus.inTransitionLose;
			}
			yield return new WaitForSeconds (1);

		} else {
			Debug.Log ("No termino el minijuego");
			yield return new WaitForSeconds (1);
		}

	}

	IEnumerator inTransitionWinCorrutine(){
		score += 1;
		/// generar animacion win
		actualCurrentStatus = currentStatus.inHub;
		yield return new WaitForSeconds (1);
	}
	IEnumerator inTransitionLoseCorrutine(){
		if (lives > 0) {
			lives--;
		}
		/// generar animacion lose
		actualCurrentStatus = currentStatus.inHub;
		yield return new WaitForSeconds (1);
	}
}
