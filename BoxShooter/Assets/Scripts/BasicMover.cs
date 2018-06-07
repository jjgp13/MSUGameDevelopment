using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {

	public float spinSpeed = 180f;
	public float motionMagnitud = 0.1f;

	public bool doSpin = true;
	public bool doMotion = false;
	
	// Update is called once per frame
	void Update () {
		if(doSpin) transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

		if(doMotion) transform.Translate(Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitud);
	}
}
