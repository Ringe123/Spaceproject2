using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {

	public float maxSpeed = 5f;
	public float rotationSpeed = 130f;

	public float hyperCharge;
	public float hyperSpeed = 50f;
	public float hyperRotation = 30f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		//Acceleration
		float movement = Input.GetAxis("Vertical");
		Vector3 pos = transform.position;

		if (movement >= 0) {
			
				
						//rotation
						Quaternion rotation = transform.rotation;
						float z = rotation.eulerAngles.z;
						z -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
						rotation = Quaternion.Euler (0, 0, z);
						transform.rotation = rotation;

						//Movement
						Vector3 velocity = new Vector3 (0, movement * maxSpeed * Time.deltaTime, 0);
						pos += rotation * velocity;
						transform.position = pos;
				}

		if (Input.GetKey(KeyCode.H)) {		

			hyperCharge += 1 * Time.deltaTime;

			if(hyperCharge >= 2)

			DoHyperSpeed();

				}
			else {
			hyperCharge = 0;
				}
	
	}

	void DoHyperSpeed(){

		//rotation
/*
		Quaternion hyperRotation = transform.rotation;
		float z = hyperRotation.eulerAngles.z;
		z -= Input.GetAxis ("Horizontal") * hyperRotation * Time.deltaTime;
		hyperRotation = Quaternion.Euler (0, 0, z);
		transform.rotation = hyperRotation;

		//Movement
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, 1 * hyperSpeed * Time.deltaTime, 0);
		pos += hyperRotation * velocity;
		transform.position = pos;
	*/
	}
}
