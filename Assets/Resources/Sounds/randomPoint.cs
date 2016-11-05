using UnityEngine;
using System.Collections;

public class randomPoint : MonoBehaviour {
	public AudioClip clip;
	public AudioSource soundPlay;
	public float randomTime;
	// Use this for initialization
	void Start () {
		randomTime = Random.Range (0.0f, 760.0f);
		soundPlay.clip = clip;
		soundPlay.time = randomTime;
		soundPlay.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
