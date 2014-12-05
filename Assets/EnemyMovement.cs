using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float maxSpeed = 5f;
	public float rotationSpeed = 130f;


	void Start () {
	
	}

	void Update () {
	
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (player != null) {
			
			Vector3 pos = transform.position;

		Vector3 playerPosition = player.transform.position - transform.position;
		playerPosition.Normalize();
		
		float zAngle = Mathf.Atan2(playerPosition.y, playerPosition.x) * Mathf.Rad2Deg - 90;

			Quaternion rotAngle = Quaternion.Euler(0,0, zAngle); 

			transform.rotation = Quaternion.RotateTowards( transform.rotation, rotAngle, rotationSpeed * Time.deltaTime);
		//rotation
		/*
		Quaternion rotation = transform.rotation;
		float z = rotation.eulerAngles.z;
		z -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		rotation = Quaternion.Euler (0, 0, z);
		transform.rotation = rotation;*/
		
		//Movement
		Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
		pos += transform.rotation * velocity;
		transform.position = pos;
		}

	}
}
