using UnityEngine;
using System.Collections;

public class DragBasic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);

			if(touch.phase == TouchPhase.Moved)
			{
				Debug.Log ("LEL");
			}

			if(touch.phase == TouchPhase.Ended)
			{
				
			}
		}
	}
}
