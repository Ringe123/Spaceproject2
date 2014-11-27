using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {

	public float planetRotation;
	public float orbitSpeed = 0.0005f;
	public GameObject orbitPoint;
	public bool debug = false;
	public bool faceOrbitPoint = false;
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (orbitPoint != null) {

			if(debug == true){
				Debug.Log(orbitPoint);
			}

			
			if (faceOrbitPoint == true) {
				
				Vector3 faceOrbit = orbitPoint.transform.position - transform.position;
				faceOrbit.Normalize();

				float zAngle = Mathf.Atan2(faceOrbit.y, faceOrbit.x) * Mathf.Rad2Deg - 90;
				transform.rotation = Quaternion.Euler(0,0, zAngle);
				transform.RotateAround (orbitPoint.transform.position, Vector3.forward, orbitSpeed * Time.deltaTime);
				
			}
		}
		transform.Rotate (Vector3.forward * planetRotation);

	}
}
