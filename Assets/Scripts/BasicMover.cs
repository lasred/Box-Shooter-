using UnityEngine;
using System.Collections;

public class BasicMover : MonoBehaviour {
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;
	public bool doMotion = false;
	public bool doSpin = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//rotate 
		if(doSpin) {
			gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
		}
		//move up and down
		if(doMotion) {
			gameObject.transform.Translate (Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
		}
	}
}
