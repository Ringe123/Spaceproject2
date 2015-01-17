using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {

	public float maxSpeed = 5f;
	public float rotationSpeed = 130f;

	public float hyperCharge;
	public float hyperSpeed = 50f;
	public float hyperRotation = 30f;

	public float mapBoundry = 1f;
	public Vector3 mapCenter = new Vector3(50,50,0);
	bool outOfBounds = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		//Acceleration
		float movement = Input.GetAxis("Vertical");
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, movement * maxSpeed * Time.deltaTime, 0);

		if (Vector3.Distance(transform.position, mapCenter) >= 50) {
			
			//turn player back to planet
			Vector3.Lerp(transform.position, mapCenter, 1000f);
			Vector3 mapCenterPoint = mapCenter - transform.position;
			float zAngle = Mathf.Atan2(mapCenterPoint.y, mapCenterPoint.x) * Mathf.Rad2Deg - 90;
			Quaternion rotAngle = Quaternion.Euler(0,0, zAngle); 
			transform.rotation = Quaternion.RotateTowards( transform.rotation, rotAngle, rotationSpeed * Time.deltaTime);

			velocity.y = maxSpeed * Time.deltaTime;

			pos += transform.rotation * velocity;
			transform.position = pos;


			Debug.Log("out of bounds");
			
		}
		else{
							
						//rotation

						Quaternion rotation = transform.rotation;
						float z = rotation.eulerAngles.z;
						z -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
						rotation = Quaternion.Euler (0, 0, z);
						transform.rotation = rotation;
					
					/*	Rotation towards mouse
					 * 
						Vector3 mousePosition = Input.mousePosition - transform.position;
						float zAngle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg - 90;
						Quaternion rotAngle = Quaternion.Euler(0,0, zAngle); 
						transform.rotation = Quaternion.RotateTowards( transform.rotation, rotAngle, rotationSpeed * Time.deltaTime);
					*/
						//Movement
									
						
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
