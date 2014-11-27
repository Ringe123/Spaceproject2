using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform myTarget;
	public float cameraSpeed; 

	// Update is called once per frame
	void Update () {
		/*
		if (myTarget != null) {
			Vector3 targetPosition = myTarget.position;
			targetPosition.z = transform.position.z;
			transform.position = targetPosition;
		
		}
		*/

		//LERP CAMERA

		if (myTarget != null) {

			Vector3 pos = Vector3.Lerp(transform.position, myTarget.transform.position, cameraSpeed);
			pos.z = transform.position.z;
			transform.position = pos;

				}

	}
}
