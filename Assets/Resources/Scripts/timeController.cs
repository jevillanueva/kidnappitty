using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class timeController : MonoBehaviour {
	public Slider timerObject;
	public float timerLimit;
	public bool cleanTimer;
	public float timerUse;
	// Use this for initialization
	void Start () {
		timerObject = this.gameObject.GetComponent<Slider> ();
		timerLimit = timerObject.maxValue;
		timerUse = timerLimit;
	}
	
	// Update is called once per frame
	void Update () {
		if (cleanTimer) {
			timerLimit = timerObject.maxValue;
			timerUse = timerLimit;
			cleanTimer = false;
		}

		if (timerUse > 0) {
			timerUse -= Time.deltaTime;
		} else {
//			GameObject manager=  GameObject.Find ("GameManagerController");

		}
		timerLimit = timerObject.value = timerUse;
	}
}
