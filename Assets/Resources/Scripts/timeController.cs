using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class timeController : MonoBehaviour {
	public Slider timerObject;
	public float timerLimit;
	public bool cleanTimer;
	public float timerUse;
	public bool timerOn;
	// Use this for initialization
	void Start () {
		timerObject = this.gameObject.GetComponent<Slider> ();
		timerLimit = timerObject.maxValue;
		timerUse = timerLimit;
	}
	
	// Update is called once per frame
	void Update () {
//		if (cleanTimer) {
//			timerLimit = timerObject.maxValue;
//			timerUse = timerLimit;
//			cleanTimer = false;
//		}
		if (timerOn) {


			if (timerUse > 0) {
				timerUse -= Time.deltaTime;
			} else {
//			GameObject manager=  GameObject.Find ("GameManagerController");
				GameObject managerGame = GameObject.FindGameObjectWithTag ("master");
				managerGame.GetComponent<generalManager> ().endMiniGame = true;
			}
			timerLimit = timerObject.value = timerUse;
		}
	}
	public void clearTimer(){
		timerLimit = timerObject.maxValue;
		timerUse = timerLimit;
		timerOn = false;
	}
	public void setMaxValue(float timeM){
		timerObject.maxValue = timeM;
	}
	public void limpiarTimer(){
		timerObject.value = 0;
		timerOn = false;
	}
}
