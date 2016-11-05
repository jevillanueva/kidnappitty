using UnityEngine;
using System.Collections;

public class Collision : miniGameBasic {

	void OnTriggerEnter2D(Collider2D col) 
	{
		//Debug.Log (col.tag);
		if(col.gameObject.tag == "Enemy")
		{
			Destroy(col.gameObject);
			miniGameStatus = false;
			endMiniGame ();
		}
	}
}
