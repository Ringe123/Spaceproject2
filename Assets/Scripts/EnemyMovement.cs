using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float maxSpeed = 5f;
	public float rotationSpeed = 130f;
	public bool debug = false;
	bool wayPointSet;
	public Vector3 wayPoint;
	bool detected;


	void Start () {
	
		wayPointSet = false;
	}

	void Update () {

		if (debug == false) {

			//Check if player is detected
			try {
				detected = gameObject.GetComponentInChildren<DetectandAttack> ().detectedPlayer;
			} catch (System.Exception ex) {
				Debug.LogError(ex);
			}

			Movement();

				}

	}

	void Movement (){

		Vector3 pos = transform.position;

		//Follow and attack player
		if (detected) {
			
			GameObject player = GameObject.FindGameObjectWithTag ("Player");

			if (player != null) {

				
				Vector3 playerPosition = player.transform.position - transform.position;
				playerPosition.Normalize ();
				
				float zAngle = Mathf.Atan2 (playerPosition.y, playerPosition.x) * Mathf.Rad2Deg - 90;
				
				Quaternion rotAngle = Quaternion.Euler (0, 0, zAngle); 				
				transform.rotation = Quaternion.RotateTowards (transform.rotation, rotAngle, rotationSpeed * Time.deltaTime);

				//Movement
				Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
				pos += transform.rotation * velocity;
				transform.position = pos;
			

			}
		}
		else {		

			if (wayPointSet == false) {

				wayPointSet = true;

				SetWayPoint();

			}
			else if (Vector3.Distance(transform.position, wayPoint) < 1) {
				Debug.Log("kommer in hit");
				SetWayPoint();

			}

			//Random movement

			Vector3 WayPointPosition = wayPoint - transform.position;
			WayPointPosition.Normalize ();

			float zAngle = Mathf.Atan2 (WayPointPosition.y, WayPointPosition.x) * Mathf.Rad2Deg - 90;			
			Quaternion rotAngle = Quaternion.Euler (0, 0, zAngle); 


			Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
			
			transform.rotation = Quaternion.RotateTowards (transform.rotation, rotAngle, rotationSpeed * Time.deltaTime);
			pos += transform.rotation * velocity;
			transform.position = pos;

     		}

	}

	void SetWayPoint(){
		/*
		wayPoint = Random.insideUnitSphere;
		wayPoint.z = 0f;
		wayPoint.y *= 50f;
		wayPoint.x *= 50f;
		*/
		float maxPos = 100f;
		float minPos = 0f;

		wayPoint = new Vector3 (Random.Range(minPos,maxPos), Random.Range(minPos,maxPos), 0);

	}

}
