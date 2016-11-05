using UnityEngine;
using System.Collections;

public class mecanicAcelerometer : MonoBehaviour {
	public float axisX, axisY, axisZ;
	public bool swDebug;
	// Use this for initialization
	public GameObject objectEquilibrate;
	public float velocity;
	public bool invertAxis;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (swDebug) {
			axisX = Input.acceleration.x;
			axisY = Input.acceleration.y;
			axisZ = Input.acceleration.z;
			Vector3 toRotate = new Vector3 (0, 0, (invertAxis ?  -1 : 1) *axisX * velocity * Time.deltaTime);
			objectEquilibrate.transform.Rotate (toRotate);
		}
	}
}
