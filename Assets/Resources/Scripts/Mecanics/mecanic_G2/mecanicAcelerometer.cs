using UnityEngine;
using System.Collections;

public class mecanicAcelerometer : MonoBehaviour {
	public float axisX, axisY, axisZ;
	public bool swStart;
	// Use this for initialization
	public GameObject objectEquilibrate;
	public float velocity;
	public bool invertAxis;
//	public Quaternion q;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (swStart) {
			axisX = Input.acceleration.x;
			axisY = Input.acceleration.y;
			axisZ = Input.acceleration.z;
			Vector3 toRotate = new Vector3 (0, 0, (invertAxis ?  -1 : 1) *axisX * velocity * Time.deltaTime);
			objectEquilibrate.transform.Rotate (toRotate);
//			float angle = Mathf.Atan2(axisX,axisY)*Mathf.Rad2Deg;
//			float x = axisX*180/Mathf.PI;

//			float y = axisY*180/Mathf.PI;
//			float z = axisY*180/Mathf.PI;
//			Debug.Log (angle);
//			Debug.Log ("x: "+x+"y: "+y+"z: "+z);
//			Vector3 look = new Vector3(1,1,angle);
//			q = Quaternion.FromToRotation(
//			objectEquilibrate.transform.rotation.SetLookRotation (look);
		}
	}
}
